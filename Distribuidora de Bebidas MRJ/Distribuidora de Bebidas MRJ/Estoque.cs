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

namespace Distribuidora_de_Bebidas_MRJ
{
    public partial class Estoque : Form
    {

        private TextBox EstoqueCod;
        private TextBox EstoqueNF;
        private TextBox EstoqueQuantidade;
        private TextBox EstoqueNome;
        private TextBox EstoqueDescricao;
        private TextBox EstoqueValor_Uni;
        private TextBox Cadastro_produtosNomeTxt;

        public Estoque()
        {
            InitializeComponent();
            DisplayEstoque();
        }

        private void DisplayEstoque()
        {
            Con.Open();
            string Query = "Select * From Cadastro_produtos";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CadastroDGV.DataSource = ds.Tables[0];
            Con.Close();
        }



        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Aluno\Desktop\Flavio_TCC_SQL\Distribuidora de Bebidas MRJ\Distribuidora de Bebidas MRJ\mrj.mdf"";Integrated Security=True;Connect Timeout=30");
        

        private void cad_prod_Click_1(object sender, EventArgs e)
        {
            cadastro_prod PG4 = new cadastro_prod();
            PG4.ShowDialog();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Principal PG2 = new Principal();
            this.Close();
            PG2.Show();
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        int Key = 0;
        private void CadastroDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Con.Open();
            EstoqueCod.Text = CadastroDGV.SelectedRows[0].Cells[1].Value.ToString();
            EstoqueNF.Text = CadastroDGV.SelectedRows[0].Cells[2].Value.ToString();
            EstoqueQuantidade.Text = CadastroDGV.SelectedRows[0].Cells[3].Value.ToString();
            EstoqueNome.Text = CadastroDGV.SelectedRows[0].Cells[4].Value.ToString();
            EstoqueDescricao.Text = CadastroDGV.SelectedRows[0].Cells[5].Value.ToString();
            EstoqueValor_Uni.Text = CadastroDGV.SelectedRows[0].Cells[6].Value.ToString();

            // Substituí Cadastro_produtosNomeTbl por Cadastro_produtosNomeTxt, presumindo que seja o nome correto do seu controle TextBox
            if (Cadastro_produtosNomeTxt.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(CadastroDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

            Con.Close();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            return;
        }
    }


}

