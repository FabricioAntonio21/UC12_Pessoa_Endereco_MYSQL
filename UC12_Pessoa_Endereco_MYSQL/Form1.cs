using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UC12_Pessoa_Endereco_MYSQL
{
    public partial class Form1 : Form
    {
        string servidor;
        MySqlConnection conexao;
        MySqlCommand comando;

        string sexo = "";
        string ultimoID;

        public Form1()
        {
            InitializeComponent();

            servidor = "Server=localhost;Database=pessoa_endereco;Uid=root;Pwd=";
            conexao = new MySqlConnection(servidor);
            comando = conexao.CreateCommand();

            atualizar_dataGRID();
            
        }

        private void atualizar_dataGRID()
        {
            try
            {
                conexao.Open();
                comando.CommandText = "SELECT *  FROM tbl_endereco INNER JOIN tbl_pessoa ON (tbl_endereco.id = fk_endereco);";

                MySqlDataAdapter adaptadorCADASTRO = new MySqlDataAdapter(comando);
                DataTable tabelaCADASTRO = new DataTable();

                adaptadorCADASTRO.Fill(tabelaCADASTRO);

                dataGridView_CADASTRO.DataSource = tabelaCADASTRO;
               
                dataGridView_CADASTRO.Columns["nome"].HeaderText = "Nome";
                dataGridView_CADASTRO.Columns["cpf"].HeaderText = "CPF";
                dataGridView_CADASTRO.Columns["logradouro"].HeaderText = "Logradouro";
                dataGridView_CADASTRO.Columns["estado"].HeaderText = "Estado";
                dataGridView_CADASTRO.Columns["nome_social"].HeaderText = "Nome Social";
                dataGridView_CADASTRO.Columns["RG"].HeaderText = "RG";
                dataGridView_CADASTRO.Columns["data_nasc"].HeaderText = "Data de Nascimento";
                dataGridView_CADASTRO.Columns["Etnia"].HeaderText = "Etnia";
                dataGridView_CADASTRO.Columns["genero"].HeaderText = "Genero";
                dataGridView_CADASTRO.Columns["bairro"].HeaderText = "Bairro";
                dataGridView_CADASTRO.Columns["cidade"].HeaderText = "Cidade";
                dataGridView_CADASTRO.Columns["uf"].HeaderText = "UF";



            }
            catch (Exception erro_mysql)
            {
                MessageBox.Show(erro_mysql.Message);
            }
            finally
            {
                conexao.Close();
            }
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label_ESTADO_Click(object sender, EventArgs e)
        {

        }

        private void button_CADASTRAR_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_endereco (logradouro, bairro, cidade, estado, uf) VALUES ('" + textBox_LOGRADOURO.Text + "', '" + textBox_BAIRRO.Text + "', '" + textBox_CIDADE.Text + "', '" + comboBox_ESTADO.SelectedItem + "', '" + comboBox_UF.SelectedItem + "');";
                comando.ExecuteNonQuery();
                MessageBox.Show("Usuário Cadastrado com sucesso!");












            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
            finally
            {
                conexao.Close();
            }


            try
            {
                conexao.Open();
                comando.CommandText = "SELECT MAX(id) FROM tbl_endereco;";
              MySqlDataReader ReaderID = comando.ExecuteReader();

                if (ReaderID.Read())
                {
                    ultimoID = ReaderID.GetString(0);
                }
 
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
            finally
            {
                conexao.Close();
            }

            try
            {
                conexao.Open();
                comando.CommandText = "INSERT INTO tbl_pessoa (nome, sobrenome, nome_social, rg, cpf, data_nasc, etnia, genero, fk_endereco) VALUES ('" + textBox_NOME.Text + "', '" + textBox_SOBRENOME.Text + "', '" + textBox_NOME_SOCIAL.Text + "', '" + textBox_RG.Text + "', '" + textBox_CPF.Text + "', '" + dateTimePicker_DATA_NASC.Value.ToString("yyyy-MM-dd") + "', '" + comboBox_ETNIA.SelectedItem + "', '" + sexo + "', '" + ultimoID + "');";
                comando.ExecuteNonQuery();
               
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
            finally
            {
                conexao.Close();
            }

            atualizar_dataGRID();

        }

        private void radioButton_GENERO1_Click(object sender, EventArgs e)
        {
            if (radioButton_GENERO1.Checked)
            {
                sexo = "Masculino";
                
            }
            
        }

        private void radioButton_GENERO2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_GENERO2.Checked)
            {
                sexo = "Feminino";
            }
            
        }

        private void radioButton_GENERO3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_GENERO3.Checked)
            {
                sexo = "OUTRO";
            }
            
        }

        private void dataGridView_CADASTRO_MouseClick(object sender, MouseEventArgs e)
        {
            textBox_LOGRADOURO.Text = dataGridView_CADASTRO.CurrentRow.Cells[1].Value.ToString();
            textBox_BAIRRO.Text = dataGridView_CADASTRO.CurrentRow.Cells[2].Value.ToString();
            textBox_CIDADE.Text = dataGridView_CADASTRO.CurrentRow.Cells[3].Value.ToString();
            comboBox_ESTADO.Text = dataGridView_CADASTRO.CurrentRow.Cells[4].Value.ToString();
            comboBox_UF.Text = dataGridView_CADASTRO.CurrentRow.Cells[5].Value.ToString();
            textBox_NOME.Text = dataGridView_CADASTRO.CurrentRow.Cells[7].Value.ToString();
            textBox_SOBRENOME.Text = dataGridView_CADASTRO.CurrentRow.Cells[8].Value.ToString();
            textBox_NOME_SOCIAL.Text = dataGridView_CADASTRO.CurrentRow.Cells[9].Value.ToString();
            textBox_RG.Text = dataGridView_CADASTRO.CurrentRow.Cells[10].Value.ToString();
            textBox_CPF.Text = dataGridView_CADASTRO.CurrentRow.Cells[11].Value.ToString();
            comboBox_ETNIA.Text = dataGridView_CADASTRO.CurrentRow.Cells[13].Value.ToString();
            dateTimePicker_DATA_NASC.Text = dataGridView_CADASTRO.CurrentRow.Cells[12].Value.ToString();

            if (dataGridView_CADASTRO.CurrentRow.Cells[14].Value.ToString() == "Masculino")
            {
                radioButton_GENERO1.Checked = true;
               
            }


            if (dataGridView_CADASTRO.CurrentRow.Cells[14].Value.ToString() == "Feminino")
            {
               
                radioButton_GENERO2.Checked = true;
                
            }


            if (dataGridView_CADASTRO.CurrentRow.Cells[14].Value.ToString() == "OUTRO")
            {
               
                radioButton_GENERO3.Checked = true;
            }

        }

        private void dataGridView_CADASTRO_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
        
    }
}
