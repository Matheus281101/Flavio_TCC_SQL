namespace Distribuidora_de_Bebidas_MRJ
{
    partial class cadastro_prod
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_buscar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lup_busc = new Guna.UI2.WinForms.Guna2TextBox();
            this.Codigo_Produto = new Guna.UI2.WinForms.Guna2TextBox();
            this.Nome_Produto = new Guna.UI2.WinForms.Guna2TextBox();
            this.Codigo_Fornecedor = new Guna.UI2.WinForms.Guna2TextBox();
            this.NF = new Guna.UI2.WinForms.Guna2TextBox();
            this.Quantidade_Produto = new Guna.UI2.WinForms.Guna2TextBox();
            this.Valor_Produto = new Guna.UI2.WinForms.Guna2TextBox();
            this.Descricao = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.Editar = new Guna.UI2.WinForms.Guna2Button();
            this.Cadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.Salvar = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.guna2GradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label_buscar
            // 
            this.Label_buscar.AutoSize = true;
            this.Label_buscar.BackColor = System.Drawing.Color.Transparent;
            this.Label_buscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_buscar.Location = new System.Drawing.Point(164, 145);
            this.Label_buscar.Name = "Label_buscar";
            this.Label_buscar.Size = new System.Drawing.Size(136, 16);
            this.Label_buscar.TabIndex = 57;
            this.Label_buscar.Text = "Código de produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(689, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 16);
            this.label2.TabIndex = 64;
            this.label2.Text = "Código de fornecedor";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(164, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 68;
            this.label4.Text = "NF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(164, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Quantidade";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 70;
            this.label6.Text = "Valor(un)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(354, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 16);
            this.label7.TabIndex = 72;
            this.label7.Text = "Descrição do produto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(354, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 16);
            this.label8.TabIndex = 73;
            this.label8.Text = "Nome do produto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(164, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 16);
            this.label1.TabIndex = 84;
            this.label1.Text = " Buscar Produto";
            // 
            // lup_busc
            // 
            this.lup_busc.BackColor = System.Drawing.Color.Black;
            this.lup_busc.BorderColor = System.Drawing.Color.Black;
            this.lup_busc.BorderRadius = 12;
            this.lup_busc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.lup_busc.DefaultText = "";
            this.lup_busc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.lup_busc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.lup_busc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lup_busc.DisabledState.Parent = this.lup_busc;
            this.lup_busc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.lup_busc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lup_busc.FocusedState.Parent = this.lup_busc;
            this.lup_busc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lup_busc.ForeColor = System.Drawing.Color.Black;
            this.lup_busc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lup_busc.HoverState.Parent = this.lup_busc;
            this.lup_busc.IconRight = global::Distribuidora_de_Bebidas_MRJ.Properties.Resources.lupaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa_removebg_preview;
            this.lup_busc.Location = new System.Drawing.Point(24, 78);
            this.lup_busc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lup_busc.Name = "lup_busc";
            this.lup_busc.PasswordChar = '\0';
            this.lup_busc.PlaceholderForeColor = System.Drawing.Color.White;
            this.lup_busc.PlaceholderText = "Nome/Código";
            this.lup_busc.SelectedText = "";
            this.lup_busc.ShadowDecoration.Parent = this.lup_busc;
            this.lup_busc.Size = new System.Drawing.Size(441, 29);
            this.lup_busc.TabIndex = 86;
            // 
            // Codigo_Produto
            // 
            this.Codigo_Produto.BackColor = System.Drawing.Color.Transparent;
            this.Codigo_Produto.BorderColor = System.Drawing.Color.Black;
            this.Codigo_Produto.BorderRadius = 12;
            this.Codigo_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Codigo_Produto.DefaultText = "";
            this.Codigo_Produto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Codigo_Produto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Codigo_Produto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Codigo_Produto.DisabledState.Parent = this.Codigo_Produto;
            this.Codigo_Produto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Codigo_Produto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Codigo_Produto.FocusedState.Parent = this.Codigo_Produto;
            this.Codigo_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_Produto.ForeColor = System.Drawing.Color.Black;
            this.Codigo_Produto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Codigo_Produto.HoverState.Parent = this.Codigo_Produto;
            this.Codigo_Produto.Location = new System.Drawing.Point(167, 165);
            this.Codigo_Produto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codigo_Produto.Name = "Codigo_Produto";
            this.Codigo_Produto.PasswordChar = '\0';
            this.Codigo_Produto.PlaceholderForeColor = System.Drawing.Color.White;
            this.Codigo_Produto.PlaceholderText = "Código";
            this.Codigo_Produto.SelectedText = "";
            this.Codigo_Produto.ShadowDecoration.Parent = this.Codigo_Produto;
            this.Codigo_Produto.Size = new System.Drawing.Size(173, 29);
            this.Codigo_Produto.TabIndex = 87;
            // 
            // Nome_Produto
            // 
            this.Nome_Produto.BackColor = System.Drawing.Color.Transparent;
            this.Nome_Produto.BorderColor = System.Drawing.Color.Black;
            this.Nome_Produto.BorderRadius = 12;
            this.Nome_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Nome_Produto.DefaultText = "";
            this.Nome_Produto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Nome_Produto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Nome_Produto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nome_Produto.DisabledState.Parent = this.Nome_Produto;
            this.Nome_Produto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Nome_Produto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nome_Produto.FocusedState.Parent = this.Nome_Produto;
            this.Nome_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome_Produto.ForeColor = System.Drawing.Color.Black;
            this.Nome_Produto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Nome_Produto.HoverState.Parent = this.Nome_Produto;
            this.Nome_Produto.Location = new System.Drawing.Point(357, 165);
            this.Nome_Produto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nome_Produto.Name = "Nome_Produto";
            this.Nome_Produto.PasswordChar = '\0';
            this.Nome_Produto.PlaceholderForeColor = System.Drawing.Color.White;
            this.Nome_Produto.PlaceholderText = "Nome do produto";
            this.Nome_Produto.SelectedText = "";
            this.Nome_Produto.ShadowDecoration.Parent = this.Nome_Produto;
            this.Nome_Produto.Size = new System.Drawing.Size(332, 29);
            this.Nome_Produto.TabIndex = 88;
            // 
            // Codigo_Fornecedor
            // 
            this.Codigo_Fornecedor.BackColor = System.Drawing.Color.Transparent;
            this.Codigo_Fornecedor.BorderColor = System.Drawing.Color.Black;
            this.Codigo_Fornecedor.BorderRadius = 12;
            this.Codigo_Fornecedor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Codigo_Fornecedor.DefaultText = "";
            this.Codigo_Fornecedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Codigo_Fornecedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Codigo_Fornecedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Codigo_Fornecedor.DisabledState.Parent = this.Codigo_Fornecedor;
            this.Codigo_Fornecedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Codigo_Fornecedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Codigo_Fornecedor.FocusedState.Parent = this.Codigo_Fornecedor;
            this.Codigo_Fornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo_Fornecedor.ForeColor = System.Drawing.Color.Black;
            this.Codigo_Fornecedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Codigo_Fornecedor.HoverState.Parent = this.Codigo_Fornecedor;
            this.Codigo_Fornecedor.Location = new System.Drawing.Point(692, 166);
            this.Codigo_Fornecedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Codigo_Fornecedor.Name = "Codigo_Fornecedor";
            this.Codigo_Fornecedor.PasswordChar = '\0';
            this.Codigo_Fornecedor.PlaceholderForeColor = System.Drawing.Color.White;
            this.Codigo_Fornecedor.PlaceholderText = "Código forneecedor";
            this.Codigo_Fornecedor.SelectedText = "";
            this.Codigo_Fornecedor.ShadowDecoration.Parent = this.Codigo_Fornecedor;
            this.Codigo_Fornecedor.Size = new System.Drawing.Size(156, 29);
            this.Codigo_Fornecedor.TabIndex = 89;
            // 
            // NF
            // 
            this.NF.BackColor = System.Drawing.Color.Transparent;
            this.NF.BorderColor = System.Drawing.Color.Black;
            this.NF.BorderRadius = 12;
            this.NF.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NF.DefaultText = "";
            this.NF.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NF.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NF.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NF.DisabledState.Parent = this.NF;
            this.NF.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NF.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NF.FocusedState.Parent = this.NF;
            this.NF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NF.ForeColor = System.Drawing.Color.Black;
            this.NF.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NF.HoverState.Parent = this.NF;
            this.NF.Location = new System.Drawing.Point(167, 223);
            this.NF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NF.Name = "NF";
            this.NF.PasswordChar = '\0';
            this.NF.PlaceholderForeColor = System.Drawing.Color.White;
            this.NF.PlaceholderText = "Nota Fiscal";
            this.NF.SelectedText = "";
            this.NF.ShadowDecoration.Parent = this.NF;
            this.NF.Size = new System.Drawing.Size(173, 29);
            this.NF.TabIndex = 90;
            this.NF.TextChanged += new System.EventHandler(this.guna2TextBox4_TextChanged);
            // 
            // Quantidade_Produto
            // 
            this.Quantidade_Produto.BackColor = System.Drawing.Color.Transparent;
            this.Quantidade_Produto.BorderColor = System.Drawing.Color.Black;
            this.Quantidade_Produto.BorderRadius = 12;
            this.Quantidade_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Quantidade_Produto.DefaultText = "";
            this.Quantidade_Produto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Quantidade_Produto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Quantidade_Produto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantidade_Produto.DisabledState.Parent = this.Quantidade_Produto;
            this.Quantidade_Produto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Quantidade_Produto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantidade_Produto.FocusedState.Parent = this.Quantidade_Produto;
            this.Quantidade_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantidade_Produto.ForeColor = System.Drawing.Color.Black;
            this.Quantidade_Produto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Quantidade_Produto.HoverState.Parent = this.Quantidade_Produto;
            this.Quantidade_Produto.Location = new System.Drawing.Point(166, 284);
            this.Quantidade_Produto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Quantidade_Produto.Name = "Quantidade_Produto";
            this.Quantidade_Produto.PasswordChar = '\0';
            this.Quantidade_Produto.PlaceholderForeColor = System.Drawing.Color.White;
            this.Quantidade_Produto.PlaceholderText = "Quantidade";
            this.Quantidade_Produto.SelectedText = "";
            this.Quantidade_Produto.ShadowDecoration.Parent = this.Quantidade_Produto;
            this.Quantidade_Produto.Size = new System.Drawing.Size(98, 29);
            this.Quantidade_Produto.TabIndex = 91;
            // 
            // Valor_Produto
            // 
            this.Valor_Produto.BackColor = System.Drawing.Color.Transparent;
            this.Valor_Produto.BorderColor = System.Drawing.Color.Black;
            this.Valor_Produto.BorderRadius = 12;
            this.Valor_Produto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Valor_Produto.DefaultText = "";
            this.Valor_Produto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Valor_Produto.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Valor_Produto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Valor_Produto.DisabledState.Parent = this.Valor_Produto;
            this.Valor_Produto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Valor_Produto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Valor_Produto.FocusedState.Parent = this.Valor_Produto;
            this.Valor_Produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor_Produto.ForeColor = System.Drawing.Color.Black;
            this.Valor_Produto.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Valor_Produto.HoverState.Parent = this.Valor_Produto;
            this.Valor_Produto.Location = new System.Drawing.Point(273, 284);
            this.Valor_Produto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Valor_Produto.Name = "Valor_Produto";
            this.Valor_Produto.PasswordChar = '\0';
            this.Valor_Produto.PlaceholderForeColor = System.Drawing.Color.White;
            this.Valor_Produto.PlaceholderText = "Valor";
            this.Valor_Produto.SelectedText = "";
            this.Valor_Produto.ShadowDecoration.Parent = this.Valor_Produto;
            this.Valor_Produto.Size = new System.Drawing.Size(67, 29);
            this.Valor_Produto.TabIndex = 92;
            // 
            // Descricao
            // 
            this.Descricao.BackColor = System.Drawing.Color.Black;
            this.Descricao.BorderColor = System.Drawing.Color.Black;
            this.Descricao.BorderRadius = 12;
            this.Descricao.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Descricao.DefaultText = "";
            this.Descricao.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Descricao.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Descricao.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Descricao.DisabledState.Parent = this.Descricao;
            this.Descricao.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Descricao.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Descricao.FocusedState.Parent = this.Descricao;
            this.Descricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descricao.ForeColor = System.Drawing.Color.Black;
            this.Descricao.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Descricao.HoverState.Parent = this.Descricao;
            this.Descricao.Location = new System.Drawing.Point(357, 223);
            this.Descricao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Descricao.Name = "Descricao";
            this.Descricao.PasswordChar = '\0';
            this.Descricao.PlaceholderForeColor = System.Drawing.Color.White;
            this.Descricao.PlaceholderText = "Descrição";
            this.Descricao.SelectedText = "";
            this.Descricao.ShadowDecoration.Parent = this.Descricao;
            this.Descricao.Size = new System.Drawing.Size(491, 90);
            this.Descricao.TabIndex = 93;
            this.Descricao.TextChanged += new System.EventHandler(this.guna2TextBox7_TextChanged);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 50;
            this.guna2GradientPanel1.Controls.Add(this.Codigo_Produto);
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.Quantidade_Produto);
            this.guna2GradientPanel1.Controls.Add(this.Valor_Produto);
            this.guna2GradientPanel1.Controls.Add(this.Codigo_Fornecedor);
            this.guna2GradientPanel1.Controls.Add(this.Label_buscar);
            this.guna2GradientPanel1.Controls.Add(this.label5);
            this.guna2GradientPanel1.Controls.Add(this.NF);
            this.guna2GradientPanel1.Controls.Add(this.Editar);
            this.guna2GradientPanel1.Controls.Add(this.Cadastrar);
            this.guna2GradientPanel1.Controls.Add(this.Descricao);
            this.guna2GradientPanel1.Controls.Add(this.Salvar);
            this.guna2GradientPanel1.Controls.Add(this.label4);
            this.guna2GradientPanel1.Controls.Add(this.Nome_Produto);
            this.guna2GradientPanel1.Controls.Add(this.label6);
            this.guna2GradientPanel1.Controls.Add(this.label9);
            this.guna2GradientPanel1.Controls.Add(this.label2);
            this.guna2GradientPanel1.Controls.Add(this.label8);
            this.guna2GradientPanel1.Controls.Add(this.label7);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(-142, -9);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1012, 477);
            this.guna2GradientPanel1.TabIndex = 94;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // Editar
            // 
            this.Editar.BackColor = System.Drawing.Color.Transparent;
            this.Editar.BorderRadius = 13;
            this.Editar.BorderThickness = 1;
            this.Editar.CheckedState.Parent = this.Editar;
            this.Editar.CustomImages.Parent = this.Editar;
            this.Editar.FillColor = System.Drawing.Color.White;
            this.Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Editar.ForeColor = System.Drawing.Color.Black;
            this.Editar.HoverState.Parent = this.Editar;
            this.Editar.Location = new System.Drawing.Point(540, 339);
            this.Editar.Name = "Editar";
            this.Editar.ShadowDecoration.Parent = this.Editar;
            this.Editar.Size = new System.Drawing.Size(75, 23);
            this.Editar.TabIndex = 95;
            this.Editar.Text = "Editar";
            this.Editar.Click += new System.EventHandler(this.Editar_Click_1);
            // 
            // Cadastrar
            // 
            this.Cadastrar.BackColor = System.Drawing.Color.Transparent;
            this.Cadastrar.BorderRadius = 13;
            this.Cadastrar.BorderThickness = 1;
            this.Cadastrar.CheckedState.Parent = this.Cadastrar;
            this.Cadastrar.CustomImages.Parent = this.Cadastrar;
            this.Cadastrar.FillColor = System.Drawing.Color.White;
            this.Cadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cadastrar.ForeColor = System.Drawing.Color.Black;
            this.Cadastrar.HoverState.Parent = this.Cadastrar;
            this.Cadastrar.Location = new System.Drawing.Point(453, 339);
            this.Cadastrar.Name = "Cadastrar";
            this.Cadastrar.ShadowDecoration.Parent = this.Cadastrar;
            this.Cadastrar.Size = new System.Drawing.Size(75, 23);
            this.Cadastrar.TabIndex = 94;
            this.Cadastrar.Text = "Cadastrar";
            this.Cadastrar.Click += new System.EventHandler(this.Cadastrar_Click);
            // 
            // Salvar
            // 
            this.Salvar.BackColor = System.Drawing.Color.DarkGray;
            this.Salvar.BorderRadius = 13;
            this.Salvar.BorderThickness = 1;
            this.Salvar.CheckedState.Parent = this.Salvar;
            this.Salvar.CustomImages.Parent = this.Salvar;
            this.Salvar.FillColor = System.Drawing.Color.White;
            this.Salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salvar.ForeColor = System.Drawing.Color.Black;
            this.Salvar.HoverState.Parent = this.Salvar;
            this.Salvar.Location = new System.Drawing.Point(453, 339);
            this.Salvar.Name = "Salvar";
            this.Salvar.ShadowDecoration.Parent = this.Salvar;
            this.Salvar.Size = new System.Drawing.Size(75, 23);
            this.Salvar.TabIndex = 65;
            this.Salvar.Text = "Salvar";
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(946, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 4;
            this.label9.Text = "000";
            // 
            // cadastro_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 442);
            this.Controls.Add(this.lup_busc);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Name = "cadastro_prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "cadastro_prod";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Label_buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox lup_busc;
        private Guna.UI2.WinForms.Guna2TextBox Codigo_Produto;
        private Guna.UI2.WinForms.Guna2TextBox Nome_Produto;
        private Guna.UI2.WinForms.Guna2TextBox Codigo_Fornecedor;
        private Guna.UI2.WinForms.Guna2TextBox NF;
        private Guna.UI2.WinForms.Guna2TextBox Quantidade_Produto;
        private Guna.UI2.WinForms.Guna2TextBox Valor_Produto;
        private Guna.UI2.WinForms.Guna2TextBox Descricao;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2Button Editar;
        private Guna.UI2.WinForms.Guna2Button Cadastrar;
        private Guna.UI2.WinForms.Guna2Button Salvar;
    }
}