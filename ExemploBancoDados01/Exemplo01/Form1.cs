using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Carro carro = new Carro();
            carro.Modelo = txtModelo.Text;
            carro.Ano = Convert.ToInt32(nudAno.Value);
            carro.Preco = Convert.ToDecimal(mtbPreco.Text);
            carro.Cor = cbCor.SelectedItem.ToString();

            // Desenvolvimento da tela de cadastro de carro

            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=T:\Documentos\MeusCarros.mdf;Integrated Security=True;Connect Timeout=30"; 
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = @"INSERT INTO carros
(modelo,ano,preco,cor)
VALUES(@MODELO,@ANO,@PRECO,@COR)";
            comando.Parameters.AddWithValue("@MODELO", carro.Modelo);
            comando.Parameters.AddWithValue("@ANO", carro.Ano);
            comando.Parameters.AddWithValue("@PRECO", carro.Preco);
            comando.Parameters.AddWithValue("@COR", carro.Cor);
            comando.ExecuteNonQuery();
            MessageBox.Show("Registrado criado com sucesso");
            LimparCampos();
            conexao.Close();
            AtualizarTabela();
        }
        private void LimparCampos()
        {
            txtModelo.Clear();
            nudAno.Value = DateTime.Now.Year;
            cbCor.SelectedIndex = -1;
            mtbPreco.Clear();
        }

        private void mtbPreco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nudAno_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblAno_Click(object sender, EventArgs e)
        {

        }

        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void cbCor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblCor_Click(object sender, EventArgs e)
        {

        }

        private void txtModelo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblModelo_Click(object sender, EventArgs e)
        {

        }
        private void AtualizarTabela()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = T:\Documentos\MeusCarros.mdf; Integrated Security = True; Connect Timeout = 30";
            conexao.Open();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "SELECT id,modelo FROM carros";

            DataTable tabela = new DataTable();
            tabela.Load(comando.ExecuteReader());
            dgvCarros.RowCount = 0;
            for (int i=0;i<tabela.Rows.Count;i++)
            {
                DataRow linha = tabela.Rows[i];
                Carro carro = new Carro();
                carro.Id = Convert.ToInt32(linha["id"]);
                carro.Modelo = linha["modelo"].ToString();
                dgvCarros.Rows.Add(new string[] { carro.Id.ToString(), carro.Modelo });

            }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
             AtualizarTabela();
        }

        private void dgvCarros_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

