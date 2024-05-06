namespace Distribuidora_de_Bebidas_MRJ
{
    partial class Estoque
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mrjDataSet = new Distribuidora_de_Bebidas_MRJ.mrjDataSet();
            this.label_TituloEstoque = new System.Windows.Forms.Label();
            this.titulo_estoque = new System.Windows.Forms.Label();
            this.lup_busc = new Guna.UI2.WinForms.Guna2TextBox();
            this.cad_prod = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.CadastroDGV = new System.Windows.Forms.DataGridView();
            this.codProdutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriçãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorUniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cadastroprodutosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mrjDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voltar = new Guna.UI2.WinForms.Guna2Button();
            this.eSTOQUEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eSTOQUETableAdapter = new Distribuidora_de_Bebidas_MRJ.mrjDataSetTableAdapters.ESTOQUETableAdapter();
            this.cadastroprodutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastro_produtos_TableAdapter = new Distribuidora_de_Bebidas_MRJ.mrjDataSetTableAdapters.Cadastro_produtos_TableAdapter();
            this.atualizar = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrjDataSet)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrjDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::Distribuidora_de_Bebidas_MRJ.Properties.Resources.imagem_2024_03_16_053918185_removebg_preview__1_;
            this.pictureBox1.Location = new System.Drawing.Point(611, 144);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(710, 776);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // mrjDataSet
            // 
            this.mrjDataSet.DataSetName = "mrjDataSet";
            this.mrjDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_TituloEstoque
            // 
            this.label_TituloEstoque.AutoSize = true;
            this.label_TituloEstoque.BackColor = System.Drawing.Color.Transparent;
            this.label_TituloEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TituloEstoque.Location = new System.Drawing.Point(275, 57);
            this.label_TituloEstoque.Name = "label_TituloEstoque";
            this.label_TituloEstoque.Size = new System.Drawing.Size(113, 16);
            this.label_TituloEstoque.TabIndex = 43;
            this.label_TituloEstoque.Text = "Buscar Produto";
            // 
            // titulo_estoque
            // 
            this.titulo_estoque.AutoSize = true;
            this.titulo_estoque.BackColor = System.Drawing.Color.Transparent;
            this.titulo_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulo_estoque.Location = new System.Drawing.Point(443, 4);
            this.titulo_estoque.Name = "titulo_estoque";
            this.titulo_estoque.Size = new System.Drawing.Size(76, 20);
            this.titulo_estoque.TabIndex = 46;
            this.titulo_estoque.Text = "Estoque";
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
            this.lup_busc.Location = new System.Drawing.Point(754, 194);
            this.lup_busc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lup_busc.Name = "lup_busc";
            this.lup_busc.PasswordChar = '\0';
            this.lup_busc.PlaceholderForeColor = System.Drawing.Color.White;
            this.lup_busc.PlaceholderText = "Nome/Código do produto";
            this.lup_busc.SelectedText = "";
            this.lup_busc.ShadowDecoration.Parent = this.lup_busc;
            this.lup_busc.Size = new System.Drawing.Size(441, 29);
            this.lup_busc.TabIndex = 87;
            // 
            // cad_prod
            // 
            this.cad_prod.BackColor = System.Drawing.Color.Transparent;
            this.cad_prod.BorderRadius = 13;
            this.cad_prod.BorderThickness = 1;
            this.cad_prod.CheckedState.Parent = this.cad_prod;
            this.cad_prod.CustomImages.Parent = this.cad_prod;
            this.cad_prod.FillColor = System.Drawing.Color.White;
            this.cad_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cad_prod.ForeColor = System.Drawing.Color.Black;
            this.cad_prod.HoverState.Parent = this.cad_prod;
            this.cad_prod.Location = new System.Drawing.Point(870, 77);
            this.cad_prod.Name = "cad_prod";
            this.cad_prod.ShadowDecoration.Parent = this.cad_prod;
            this.cad_prod.Size = new System.Drawing.Size(91, 28);
            this.cad_prod.TabIndex = 95;
            this.cad_prod.Text = "Cadastrar";
            this.cad_prod.Click += new System.EventHandler(this.cad_prod_Click_1);
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2GradientPanel1.BorderRadius = 50;
            this.guna2GradientPanel1.Controls.Add(this.atualizar);
            this.guna2GradientPanel1.Controls.Add(this.CadastroDGV);
            this.guna2GradientPanel1.Controls.Add(this.cad_prod);
            this.guna2GradientPanel1.Controls.Add(this.label_TituloEstoque);
            this.guna2GradientPanel1.Controls.Add(this.titulo_estoque);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(476, 117);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(973, 827);
            this.guna2GradientPanel1.TabIndex = 96;
            this.guna2GradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2GradientPanel1_Paint);
            // 
            // CadastroDGV
            // 
            this.CadastroDGV.AllowUserToOrderColumns = true;
            this.CadastroDGV.AutoGenerateColumns = false;
            this.CadastroDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CadastroDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codProdutoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nFDataGridViewTextBoxColumn,
            this.descriçãoDataGridViewTextBoxColumn,
            this.valorUniDataGridViewTextBoxColumn,
            this.quantidadeDataGridViewTextBoxColumn});
            this.CadastroDGV.DataSource = this.cadastroprodutosBindingSource1;
            this.CadastroDGV.Location = new System.Drawing.Point(145, 113);
            this.CadastroDGV.Name = "CadastroDGV";
            this.CadastroDGV.Size = new System.Drawing.Size(637, 130);
            this.CadastroDGV.TabIndex = 96;
            this.CadastroDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CadastroDGV_CellContentClick);
            // 
            // codProdutoDataGridViewTextBoxColumn
            // 
            this.codProdutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.codProdutoDataGridViewTextBoxColumn.DataPropertyName = "Cod_Produto";
            this.codProdutoDataGridViewTextBoxColumn.HeaderText = "Cod_Produto";
            this.codProdutoDataGridViewTextBoxColumn.Name = "codProdutoDataGridViewTextBoxColumn";
            this.codProdutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.codProdutoDataGridViewTextBoxColumn.Width = 94;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            // 
            // nFDataGridViewTextBoxColumn
            // 
            this.nFDataGridViewTextBoxColumn.DataPropertyName = "NF";
            this.nFDataGridViewTextBoxColumn.HeaderText = "NF";
            this.nFDataGridViewTextBoxColumn.Name = "nFDataGridViewTextBoxColumn";
            // 
            // descriçãoDataGridViewTextBoxColumn
            // 
            this.descriçãoDataGridViewTextBoxColumn.DataPropertyName = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descriçãoDataGridViewTextBoxColumn.Name = "descriçãoDataGridViewTextBoxColumn";
            // 
            // valorUniDataGridViewTextBoxColumn
            // 
            this.valorUniDataGridViewTextBoxColumn.DataPropertyName = "Valor_Uni";
            this.valorUniDataGridViewTextBoxColumn.HeaderText = "Valor_Uni";
            this.valorUniDataGridViewTextBoxColumn.Name = "valorUniDataGridViewTextBoxColumn";
            // 
            // quantidadeDataGridViewTextBoxColumn
            // 
            this.quantidadeDataGridViewTextBoxColumn.DataPropertyName = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.HeaderText = "Quantidade";
            this.quantidadeDataGridViewTextBoxColumn.Name = "quantidadeDataGridViewTextBoxColumn";
            // 
            // cadastroprodutosBindingSource1
            // 
            this.cadastroprodutosBindingSource1.DataMember = "Cadastro_produtos ";
            this.cadastroprodutosBindingSource1.DataSource = this.mrjDataSetBindingSource;
            // 
            // mrjDataSetBindingSource
            // 
            this.mrjDataSetBindingSource.DataSource = this.mrjDataSet;
            this.mrjDataSetBindingSource.Position = 0;
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Transparent;
            this.voltar.BorderRadius = 13;
            this.voltar.BorderThickness = 1;
            this.voltar.CheckedState.Parent = this.voltar;
            this.voltar.CustomImages.Parent = this.voltar;
            this.voltar.FillColor = System.Drawing.Color.White;
            this.voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.Black;
            this.voltar.HoverState.Parent = this.voltar;
            this.voltar.Location = new System.Drawing.Point(12, 12);
            this.voltar.Name = "voltar";
            this.voltar.ShadowDecoration.Parent = this.voltar;
            this.voltar.Size = new System.Drawing.Size(91, 28);
            this.voltar.TabIndex = 97;
            this.voltar.Text = "Voltar";
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // eSTOQUEBindingSource
            // 
            this.eSTOQUEBindingSource.DataMember = "ESTOQUE";
            this.eSTOQUEBindingSource.DataSource = this.mrjDataSetBindingSource;
            // 
            // eSTOQUETableAdapter
            // 
            this.eSTOQUETableAdapter.ClearBeforeFill = true;
            // 
            // cadastroprodutosBindingSource
            // 
            this.cadastroprodutosBindingSource.DataMember = "Cadastro_produtos ";
            this.cadastroprodutosBindingSource.DataSource = this.mrjDataSetBindingSource;
            // 
            // cadastro_produtos_TableAdapter
            // 
            this.cadastro_produtos_TableAdapter.ClearBeforeFill = true;
            // 
            // atualizar
            // 
            this.atualizar.BackColor = System.Drawing.Color.Transparent;
            this.atualizar.BorderRadius = 13;
            this.atualizar.BorderThickness = 1;
            this.atualizar.CheckedState.Parent = this.atualizar;
            this.atualizar.CustomImages.Parent = this.atualizar;
            this.atualizar.FillColor = System.Drawing.Color.White;
            this.atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.atualizar.ForeColor = System.Drawing.Color.Black;
            this.atualizar.HoverState.Parent = this.atualizar;
            this.atualizar.Location = new System.Drawing.Point(870, 122);
            this.atualizar.Name = "atualizar";
            this.atualizar.ShadowDecoration.Parent = this.atualizar;
            this.atualizar.Size = new System.Drawing.Size(91, 28);
            this.atualizar.TabIndex = 97;
            this.atualizar.Text = "Atualizar";
            this.atualizar.Click += new System.EventHandler(this.atualizar_Click);
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(71)))), ((int)(((byte)(77)))));
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.lup_busc);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Estoque";
            this.Text = "Estoque";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrjDataSet)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CadastroDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mrjDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eSTOQUEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroprodutosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_TituloEstoque;
        private System.Windows.Forms.Label titulo_estoque;
        private Guna.UI2.WinForms.Guna2TextBox lup_busc;
        private Guna.UI2.WinForms.Guna2Button cad_prod;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2Button voltar;
        private mrjDataSet mrjDataSet;
        private System.Windows.Forms.BindingSource mrjDataSetBindingSource;
        private System.Windows.Forms.BindingSource eSTOQUEBindingSource;
        private mrjDataSetTableAdapters.ESTOQUETableAdapter eSTOQUETableAdapter;
        private System.Windows.Forms.BindingSource cadastroprodutosBindingSource;
        private mrjDataSetTableAdapters.Cadastro_produtos_TableAdapter cadastro_produtos_TableAdapter;
        private System.Windows.Forms.DataGridView CadastroDGV;
        private System.Windows.Forms.BindingSource cadastroprodutosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codProdutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriçãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorUniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantidadeDataGridViewTextBoxColumn;
        private Guna.UI2.WinForms.Guna2Button atualizar;
    }
}