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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Vendas PG5 = new Vendas();
            this.Close();
            PG5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NFs PG3 = new NFs();
            this.Close();
            PG3.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Fornecedores PG6 = new Fornecedores();
            this.Close();
            PG6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Estoque PG4 = new Estoque();
            this.Close();
            PG4.Show();
        }
    }
}
