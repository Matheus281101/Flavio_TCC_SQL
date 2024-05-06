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
    public partial class cadastro_prod : Form
    {
        public cadastro_prod()
        {
            InitializeComponent();
            DisplayProdutos();
            Salvar.Hide();
            label1.Hide();
            lup_busc.Hide();

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Aluno\Desktop\Flavio_TCC_SQL\Distribuidora de Bebidas MRJ\Distribuidora de Bebidas MRJ\mrj.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayProdutos()
        {
            
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Editar_Click_1(object sender, EventArgs e)
        {
            Cadastrar.Hide();
            Salvar.Show();
            label1.Show();
            lup_busc.Show();
        }

        private void Salvar_Click_1(object sender, EventArgs e)
        {
            Cadastrar.Show();
            Salvar.Hide();
            label1.Hide();
            lup_busc.Hide();
        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Insert into Cadastro_produtos (Cod_Produto,Nome,NF,Descricao,Valor_Uni,Quantidade) values (@CP,@NM,@NF,@DC,@VU,@QT)", Con);
                    cmd.Parameters.AddWithValue("@CP", Codigo_Produto.Text);
                    cmd.Parameters.AddWithValue("@NM", Nome_Produto.Text);
                    cmd.Parameters.AddWithValue("@NF", NF.Text);
                    cmd.Parameters.AddWithValue("@DC", Descricao.Text);
                    cmd.Parameters.AddWithValue("@VU", Valor_Produto.Text);
                    cmd.Parameters.AddWithValue("@QT", Quantidade_Produto.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Produto Adicionado!");
                    Con.Close();
                   
                    


                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            
        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
