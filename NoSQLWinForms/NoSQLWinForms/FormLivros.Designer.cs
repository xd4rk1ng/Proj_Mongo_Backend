namespace NoSQLWinForms
{
    partial class FormLivros
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
            lstLivros = new ListBox();
            lblDtPublicacao = new Label();
            cmbAutor = new ComboBox();
            lblAutor = new Label();
            cmbSubtitulo = new ComboBox();
            lblSubtitulo = new Label();
            cmbTitulo = new ComboBox();
            lblTitulo = new Label();
            cmbIsbn = new ComboBox();
            lblIsbn = new Label();
            cmbEditora = new ComboBox();
            lblEditora = new Label();
            lblPgs = new Label();
            cmbDesc = new ComboBox();
            lblDesc = new Label();
            btnInserir = new Button();
            nmPags = new NumericUpDown();
            dtpPubl = new DateTimePicker();
            btnClean = new Button();
            btnFilters = new Button();
            ((System.ComponentModel.ISupportInitialize)nmPags).BeginInit();
            SuspendLayout();
            // 
            // lstLivros
            // 
            lstLivros.FormattingEnabled = true;
            lstLivros.ItemHeight = 15;
            lstLivros.Location = new Point(12, 12);
            lstLivros.Name = "lstLivros";
            lstLivros.Size = new Size(200, 529);
            lstLivros.TabIndex = 2;
            lstLivros.SelectedIndexChanged += lstLivros_SelectedIndexChanged;
            // 
            // lblDtPublicacao
            // 
            lblDtPublicacao.AutoSize = true;
            lblDtPublicacao.Location = new Point(232, 236);
            lblDtPublicacao.Name = "lblDtPublicacao";
            lblDtPublicacao.Size = new Size(152, 15);
            lblDtPublicacao.TabIndex = 21;
            lblDtPublicacao.Text = "Data de publicação(Tooltip)";
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(232, 195);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(190, 23);
            cmbAutor.TabIndex = 20;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(232, 177);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 19;
            lblAutor.Text = "Autor";
            // 
            // cmbSubtitulo
            // 
            cmbSubtitulo.FormattingEnabled = true;
            cmbSubtitulo.Location = new Point(232, 138);
            cmbSubtitulo.Name = "cmbSubtitulo";
            cmbSubtitulo.Size = new Size(190, 23);
            cmbSubtitulo.TabIndex = 18;
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(232, 120);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(55, 15);
            lblSubtitulo.TabIndex = 17;
            lblSubtitulo.Text = "Subtitulo";
            // 
            // cmbTitulo
            // 
            cmbTitulo.FormattingEnabled = true;
            cmbTitulo.Location = new Point(232, 82);
            cmbTitulo.Name = "cmbTitulo";
            cmbTitulo.Size = new Size(190, 23);
            cmbTitulo.TabIndex = 16;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(232, 64);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 15;
            lblTitulo.Text = "Titulo";
            // 
            // cmbIsbn
            // 
            cmbIsbn.FormattingEnabled = true;
            cmbIsbn.Location = new Point(232, 27);
            cmbIsbn.Name = "cmbIsbn";
            cmbIsbn.Size = new Size(190, 23);
            cmbIsbn.TabIndex = 14;
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(232, 9);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(29, 15);
            lblIsbn.TabIndex = 13;
            lblIsbn.Text = "Isbn";
            // 
            // cmbEditora
            // 
            cmbEditora.FormattingEnabled = true;
            cmbEditora.Location = new Point(232, 310);
            cmbEditora.Name = "cmbEditora";
            cmbEditora.Size = new Size(190, 23);
            cmbEditora.TabIndex = 24;
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(232, 292);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 23;
            lblEditora.Text = "Editora";
            // 
            // lblPgs
            // 
            lblPgs.AutoSize = true;
            lblPgs.Location = new Point(232, 345);
            lblPgs.Name = "lblPgs";
            lblPgs.Size = new Size(111, 15);
            lblPgs.TabIndex = 25;
            lblPgs.Text = "Numero de paginas";
            // 
            // cmbDesc
            // 
            cmbDesc.FormattingEnabled = true;
            cmbDesc.Location = new Point(451, 27);
            cmbDesc.Name = "cmbDesc";
            cmbDesc.Size = new Size(216, 23);
            cmbDesc.TabIndex = 28;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(451, 9);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 27;
            lblDesc.Text = "Descrição";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(232, 471);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(190, 70);
            btnInserir.TabIndex = 29;
            btnInserir.Text = "Inserir novo livro";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // nmPags
            // 
            nmPags.Location = new Point(232, 363);
            nmPags.Name = "nmPags";
            nmPags.Size = new Size(120, 23);
            nmPags.TabIndex = 30;
            // 
            // dtpPubl
            // 
            dtpPubl.Location = new Point(232, 254);
            dtpPubl.Name = "dtpPubl";
            dtpPubl.Size = new Size(200, 23);
            dtpPubl.TabIndex = 31;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.IndianRed;
            btnClean.Location = new Point(296, 400);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(56, 53);
            btnClean.TabIndex = 33;
            btnClean.Text = "Limpar Filtros";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // btnFilters
            // 
            btnFilters.BackColor = SystemColors.ActiveCaption;
            btnFilters.Location = new Point(234, 400);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(56, 53);
            btnFilters.TabIndex = 32;
            btnFilters.Text = "Aplicar Filtros";
            btnFilters.UseVisualStyleBackColor = false;
            btnFilters.Click += btnFilters_Click;
            // 
            // FormLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 561);
            Controls.Add(btnClean);
            Controls.Add(btnFilters);
            Controls.Add(dtpPubl);
            Controls.Add(nmPags);
            Controls.Add(btnInserir);
            Controls.Add(cmbDesc);
            Controls.Add(lblDesc);
            Controls.Add(lblPgs);
            Controls.Add(cmbEditora);
            Controls.Add(lblEditora);
            Controls.Add(lblDtPublicacao);
            Controls.Add(cmbAutor);
            Controls.Add(lblAutor);
            Controls.Add(cmbSubtitulo);
            Controls.Add(lblSubtitulo);
            Controls.Add(cmbTitulo);
            Controls.Add(lblTitulo);
            Controls.Add(cmbIsbn);
            Controls.Add(lblIsbn);
            Controls.Add(lstLivros);
            Name = "FormLivros";
            Text = "FormLivros";
            Load += FormLivros_Load;
            ((System.ComponentModel.ISupportInitialize)nmPags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstLivros;
        private Label lblDtPublicacao;
        private ComboBox cmbAutor;
        private Label lblAutor;
        private ComboBox cmbSubtitulo;
        private Label lblSubtitulo;
        private ComboBox cmbTitulo;
        private Label lblTitulo;
        private ComboBox cmbIsbn;
        private Label lblIsbn;
        private ComboBox cmbEditora;
        private Label lblEditora;
        private Label lblPgs;
        private ComboBox cmbDesc;
        private Label lblDesc;
        private Button btnInserir;
        private NumericUpDown nmPags;
        private DateTimePicker dtpPubl;
        private Button btnClean;
        private Button btnFilters;
    }
}