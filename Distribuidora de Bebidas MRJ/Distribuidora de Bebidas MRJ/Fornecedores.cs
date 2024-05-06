using Refit;
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
using static Distribuidora_de_Bebidas_MRJ.mrjDataSet;


namespace Distribuidora_de_Bebidas_MRJ
{
    public partial class Fornecedores : Form
    {

        private TextBox FornecedorCNPJ;
        private TextBox FornecedorNome;
        private TextBox FornecedorStatuss;
        private TextBox FornecedorContato;
        private TextBox FornecedorEmail;
        private TextBox FornecedorRazao;
        private TextBox FornecedorTele1;
        private TextBox FornecedorTele2;
        private TextBox FornecedorEndereco;
        private TextBox FornecedorN;
        private TextBox FornecedorComplemento;
        private TextBox FornecedorBairro;
        private TextBox FornecedorCEP;
        private TextBox FornecedorObservacoes;



        public Fornecedores()
        {
            InitializeComponent();
            DisplayFornecedores();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""E:\Flavio_TCC_SQL\Distribuidora de Bebidas MRJ\Distribuidora de Bebidas MRJ\mrj.mdf"";Integrated Security=True;Connect Timeout=30");

        private void DisplayFornecedores()
        {
            Con.Open();
            string Query = "Select * From Cadastro_produtos";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FornecedorDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'mrjDataSet.Fornecedor'. Você pode movê-la ou removê-la conforme necessário.
            salvar.Hide();
            Label_buscar.Hide();
            Buscar_forn.Hide();
        }

        private void voltar_Click_1(object sender, EventArgs e)
        {
            Principal PG2 = new Principal();
            this.Close();
            PG2.Show();
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            editar.Show();
            cadastrar.Show();
            salvar.Hide();
            titulo.Text = "Cadastrar Fornecedores";
            Label_buscar.Hide();
            Buscar_forn.Hide();

            //Limpando TextBox!!!
            Buscar_forn.Text = "";
            CNPJ.Text = "";
            Nome_Fantasia.Text = "";
            status.Text = "";
            contato.Text = "";
            email.Text = "";
            Razao_Social.Text = "";
            telefone1.Text = "";
            telefone2.Text = "";
            endereco1.Text = "";
            num.Text = "";
            complemento.Text = "";
            localidade.Text = "";
            cep.Text = "";
            observacoes.Text = "";
        }

        private void editar_Click(object sender, EventArgs e)
        {
            editar.Hide();
            cadastrar.Hide();
            salvar.Show();
            titulo.Text = "Editar Fornecedores";
            Label_buscar.Show();
            Buscar_forn.Show();
        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into Fornecedor (CNPJ,Nome_Fantasia,Statuss,Contato,Email,Razao_Social,Telefone1,Telefone2,Endereco,N,Complemento,Bairro,CEP,Observacoes) values (@CJ,@NMF,@STT,@CTT,@EM,@RZ,@TL1,@TL2,@ED,@N,@COM,@BA,@CEP,@OBS)", Con);
                cmd.Parameters.AddWithValue("@CJ", CNPJ.Text);
                cmd.Parameters.AddWithValue("@NMF", Nome_Fantasia.Text);
                cmd.Parameters.AddWithValue("@STT", status.Text);
                cmd.Parameters.AddWithValue("@CTT", contato.Text);
                cmd.Parameters.AddWithValue("@EM", email.Text);
                cmd.Parameters.AddWithValue("@RZ", Razao_Social.Text);
                cmd.Parameters.AddWithValue("@TL1", telefone1.Text);
                cmd.Parameters.AddWithValue("@TL2", telefone2.Text);
                cmd.Parameters.AddWithValue("@ED", endereco1.Text);
                cmd.Parameters.AddWithValue("@N", num.Text);
                cmd.Parameters.AddWithValue("@COM", complemento.Text);
                cmd.Parameters.AddWithValue("@BA", localidade.Text);
                cmd.Parameters.AddWithValue("@CEP", cep.Text);
                cmd.Parameters.AddWithValue("@OBS", observacoes.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Produto Adicionado!");
                




            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

            //Limpando TextBox!!!
            Buscar_forn.Text = "";
            CNPJ.Text = "";
            Nome_Fantasia.Text = "";
            status.Text = "";
            contato.Text = "";
            email.Text = "";
            Razao_Social.Text = "";
            telefone1.Text = "";
            telefone2.Text = "";
            endereco1.Text = "";
            num.Text = "";
            complemento.Text = "";
            localidade.Text = "";
            cep.Text = "";
            observacoes.Text = "";

            Con.Close();
        }

       

        async Task BuscarCep(string cep)
        {
            try
            {
                var cepBuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await cepBuscar.GetAddressAsync(cep);


                endereco1.Text = endereco.Logradouro;
                uf.Text = endereco.UF;
                localidade.Text = endereco.Bairro;

            }
            catch (Exception e)
            {
                MessageBox.Show("Falha! \n" + e);
            }
        }

        private void cep_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                localidade.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void CNPJ_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                Nome_Fantasia.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void Nome_Fantasia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                contato.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void E_mail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                Razao_Social.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void Razao_Social_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                telefone1.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void contato_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                email.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void telefone1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                telefone2.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void telefone2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                endereco1.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void endereco_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                num.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void num_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                complemento.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void observacoes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                endereco1.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void complemento_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                localidade.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private void bairro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                uf.Focus(); // Isso define o foco na próxima caixa de texto
            }
        }

        private async void cep_Leave(object sender, EventArgs e)
        {
            await BuscarCep(cep.Text);
        }

        private void uf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Isso impede que o caractere 'Enter' seja inserido na caixa de texto
                observacoes.Focus(); // Isso define o foco na próxima caixa de texto
            }
            
        }

        int Key = 0;
        private void FornecedorDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Con.Open();
            FornecedorCNPJ.Text = FornecedorDGV.SelectedRows[0].Cells[1].Value.ToString();
            FornecedorNome.Text = FornecedorDGV.SelectedRows[0].Cells[2].Value.ToString();
            FornecedorStatuss.Text = FornecedorDGV.SelectedRows[0].Cells[3].Value.ToString();
            FornecedorContato.Text = FornecedorDGV.SelectedRows[0].Cells[4].Value.ToString();
            FornecedorEmail.Text = FornecedorDGV.SelectedRows[0].Cells[5].Value.ToString();
            FornecedorRazao.Text = FornecedorDGV.SelectedRows[0].Cells[6].Value.ToString();
            FornecedorTele1.Text = FornecedorDGV.SelectedRows[0].Cells[7].Value.ToString();
            FornecedorTele2.Text = FornecedorDGV.SelectedRows[0].Cells[8].Value.ToString();
            FornecedorEndereco.Text = FornecedorDGV.SelectedRows[0].Cells[9].Value.ToString();
            FornecedorN.Text = FornecedorDGV.SelectedRows[0].Cells[10].Value.ToString();
            FornecedorComplemento.Text = FornecedorDGV.SelectedRows[0].Cells[11].Value.ToString();
            FornecedorBairro.Text = FornecedorDGV.SelectedRows[0].Cells[12].Value.ToString();
            FornecedorCEP.Text = FornecedorDGV.SelectedRows[0].Cells[13].Value.ToString();
            FornecedorObservacoes.Text = FornecedorDGV.SelectedRows[0].Cells[14].Value.ToString();


            if (FornecedorNome.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(FornecedorDGV.SelectedRows[0].Cells[0].Value.ToString());
            }

            Con.Close();
        }

        private void atualizar_Click(object sender, EventArgs e)
        {
            return;
        }
    }

 }
