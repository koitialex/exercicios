using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace cadastroClientes
{
    public partial class frmCadastroCliente : Form
    {
        MySqlConnection Conexao;
        string data_source = "datasource=localhost;username=root;password=;database=db_cadastro";
        private int ?codigo_cliente = null;
        public frmCadastroCliente()
        {

            InitializeComponent();

            //config inicial do listview
            lstCliente.View = View.Details;         //Define a visualização como Detalhes
            lstCliente.LabelEdit = true;            //Permite editar os títulos das colunas
            lstCliente.AllowColumnReorder = true;   //Permite reordenar as colunas
            lstCliente.FullRowSelect = true;        //Seleciona a linha inteira ao clicar 
            lstCliente.GridLines = true;            //Exibe as linhas de grade do ListView

            //Definindo as colunas do Listview
            lstCliente.Columns.Add("Codigo", 100, HorizontalAlignment.Left);          //Coluna de código  
            lstCliente.Columns.Add("Nome Completo", 200, HorizontalAlignment.Left);   //Coluna de Nome Completo  
            lstCliente.Columns.Add("Nome social", 200, HorizontalAlignment.Left);     //Coluna de Nome Social  
            lstCliente.Columns.Add("E-mail", 200, HorizontalAlignment.Left);          //Coluna de E-mail  
            lstCliente.Columns.Add("CPF", 200, HorizontalAlignment.Left);             //Coluna de CPF  

            //carregar os dados dos clientes na interface
            carregar_clientes();
        }
        private void carregar_clientes_com_query(string query)
        {
            try
            {
                //cria a conexão com o banco de dados
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();
                //executa a consulta sql fornecida
                MySqlCommand cmd = new MySqlCommand(query, Conexao);

                //se a consulta contem o paramentro @q, adiciona o valor da caixa de pesquisa
                if(query.Contains("@q"))
                {
                    cmd.Parameters.AddWithValue("@q", "%" + txtBuscar.Text + "%"); //@q é a mesma coisa que like % "" % para buscar tudo que for digitado entre estes dois % dentro do banco de dados

                }
                //Executar o comando e obtém os resultados
                MySqlDataReader reader = cmd.ExecuteReader();

                //Limpa os itens existente no ListView antes de adicionar novos
                lstCliente.Items.Clear();

                //Preenche o ListView com os dados dos clientes
                while (reader.Read())
                {
                    //cria uma linha para cada cliente com os dados retornados da consulta
                    string[] row =
                    {
                    Convert.ToString(reader.GetInt32(0)),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4)

                    };

                //adiciona a linha ao listview
                lstCliente.Items.Add(new ListViewItem(row));
                };
            }
            catch (MySqlException ex)
            {
                //Erro ao Mysql caso ele estiver desconectado ou desligado
                MessageBox.Show("Erro:" + ex.Number + "Ocorreu:" + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                //erro para outros tipos de erros
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                //garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if (Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    //conexão fechou com sucesso
                    Conexao.Close();
                    //MessageBox.Show("Conexão fechada com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void carregar_clientes()
        {
            string query = "SELECT * FROM dadosdecliente ORDER BY codigo DESC";
            carregar_clientes_com_query(query);
        }
        //valisação regex
        private bool isvalidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);

        }
        //função para validar se o cpf tem exatamente 11 digitos numéricos
        private bool isValidCPFLegth(string cpf)
        {
            //remover . e -
            cpf = cpf.Replace(".", "").Replace("-", "");

            if(cpf.Length != 11 || !cpf.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }
        //preencher campos obrigados, caso contráro não permitirá 
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtNomeCompleto.Text.Trim()) ||
                    string.IsNullOrEmpty(txtEmail.Text.Trim()) ||
                    string.IsNullOrEmpty(txtCpf.Text.Trim()))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; //Impede o prosseguimento se algum campo estiver vazio
                }
                string email = txtEmail.Text.Trim();
                if (!isvalidEmail(email))
                {
                    MessageBox.Show("email inválido. Certifique-se de que o @ e . estejam presentes ", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string cpf = txtCpf.Text.Trim();
                if(!isValidCPFLegth(cpf))
                {
                    MessageBox.Show("cpf inválido. Certifique-se de que o CPF tenha 11 digitos numéricos ", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    MessageBox.Show("registrado com sucesso ", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                Conexao = new MySqlConnection(data_source);
                Conexao.Open();

                MessageBox.Show("Conexão aberta com sucesso");
                //Comando sql para inserir um novo cliente no banco de dados
                MySqlCommand cmd = new MySqlCommand
                {
                    Connection = Conexao
                };
                //preparando o sql 
                cmd.Prepare();

                if (codigo_cliente == null)
                {
                    //insert Create
                    cmd.CommandText = "insert into dadosdecliente(nomecompleto,nomesocial,email,cpf) values(@nomecompleto,@nomesocial,@email,@cpf)";

                    //adicionar os parâmetros com os dados do formulário
                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    //executar o comanda para inserir no banco 
                    cmd.ExecuteNonQuery();
                
                    //menssagem de sucesso
                    MessageBox.Show("Contatos inseridos com sucesso","Sucesso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    //update
                    cmd.CommandText = $"UPDATE `dadosdecliente` SET " +
                    $"nomecompleto = @nomecompleto, " +
                    $"nomesocial = @nomesocial, " +
                    $"email = @email, " +
                    $"cpf = @cpf " +
                    $"WHERE codigo = @codigo";

                    cmd.Parameters.AddWithValue("@nomecompleto", txtNomeCompleto.Text.Trim());
                    cmd.Parameters.AddWithValue("@nomesocial", txtNomeSocial.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@cpf", cpf);
                    cmd.Parameters.AddWithValue("@codigo", codigo_cliente);
                    //executa o comando de alteração no banco 
                    cmd.ExecuteNonQuery();
                    //Messagem de sucesso
                    MessageBox.Show($"Os dados com o código {codigo_cliente} foram alterados com Sucesso!" ,"Sucesso", 
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                }

                codigo_cliente = null;
                //limpa os campos no após o sucesso
                txtNomeCompleto.Text = String.Empty;
                txtNomeSocial.Text = " ";
                txtEmail.Text = " ";
                txtCpf.Text = " ";

                //rECARREGAR OS clientes na listview
                carregar_clientes();

                //muda para a aba de pesquisa 
                tbCons.SelectedIndex = 1;

            }
            catch(MySqlException ex)
            {
                //Erro ao Mysql
                MessageBox.Show("Erro:" + ex.Number + "Ocorreu:" + ex.Message, "Erro",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception ex)
            {
                //erro para outros tipos de erros
                MessageBox.Show("Ocorreu: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                //garante que a conexão com o banco será fechada, mesmo se ocorrer erro
                if(Conexao != null && Conexao.State == ConnectionState.Open)
                {
                    //conexão fechou com sucesso
                    Conexao.Close();
                   
                }
            }
            carregar_clientes();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            string query = "Select * FROM dadosdecliente WHERE nomecompleto LIKE @q OR nomesocial LIKE @q ORDER BY codigo DESC";
            carregar_clientes_com_query(query);
        }

        private void lstCliente_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection clientedaselecao = lstCliente.SelectedItems;

            foreach(ListViewItem item in clientedaselecao)
            {
                //convete o texto que é retirado do banco de dados e transforma em número para amazenar em codigo_cliente
                codigo_cliente = Convert.ToInt32(item.SubItems[0].Text);

                //Exibe uma MessageBox com o código do cliente
                MessageBox.Show("Código do Cliente:" + codigo_cliente.ToString(), "Código Selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtNomeCompleto.Text = item.SubItems[1].Text;
                txtNomeSocial.Text = item.SubItems[2].Text;
                txtEmail.Text = item.SubItems[3].Text;
                txtCpf.Text = item.SubItems[4].Text;
            }
            //Muda para a aba de dados do cliente
            tbCons.SelectedIndex = 0;
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            codigo_cliente = null;
            //limpa os campos no após o sucesso
            txtNomeCompleto.Text = String.Empty;
            txtNomeSocial.Text = " ";
            txtEmail.Text = " ";
            txtCpf.Text = " ";

            txtNomeCompleto.Focus();
        }
    }
}
