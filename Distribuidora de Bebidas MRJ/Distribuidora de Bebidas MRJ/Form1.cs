using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Distribuidora_de_Bebidas_MRJ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                ShowPassword.Text = "Esconder Senha";
                password.UseSystemPasswordChar = false;
            }
            else
            {
                ShowPassword.Text = "Mostrar Senha";
                password.UseSystemPasswordChar = true;
            }

        }

        private void Entrar_Click(object sender, EventArgs e)
        {
            string user = (username.Text);
            string pass = (password.Text);
            string username1 = "MRJ", password1 = "MRJ1234";

            if (user != username1 || pass != password1)
            {
                MessageBox.Show("Usuário ou Senha incorreto!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                username.Text = "";
                password.Text = "";
            }
            else
            {

                Principal PG2 = new Principal();
                this.Hide();
                PG2.Show();
            }
        }

        private void username_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                password.Focus(); // Isso define o foco na próxima caixa de texto
            }

        }

        private void username_TextChanged(object sender, EventArgs e)
        {

        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                Entrar.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
