using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora_de_Bebidas_MRJ
{
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            textBox2.ReadOnly = true;
            textBox2.Enabled = false;//TESTAR, FUNÇÃO PARA NÃO DEIXAR NGM CLICAR!!!!
        }
        int cont = 0000;

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltar_Click_1(object sender, EventArgs e)
        {
            Principal PG2 = new Principal();
            this.Close();
            PG2.Show();
        }

        private void Concluir_Click_1(object sender, EventArgs e)
        {
            //Conclusao_venda PG5 = new Conclusao_venda();
            //this.Close();
            //PG5.Show();
            cont++;

            label3.Text = "" + cont;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
