namespace NoSQLWinForms
{
    partial class FormInserirLivros
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
            lblDesc = new Label();
            lblPgs = new Label();
            lblEditora = new Label();
            lblDtPublicacao = new Label();
            lblAutor = new Label();
            lblSubtitulo = new Label();
            lblTitulo = new Label();
            lblIsbn = new Label();
            txtIsbn = new TextBox();
            txtTitulo = new TextBox();
            txtSubtitulo = new TextBox();
            txtAutor = new TextBox();
            dtpPub = new DateTimePicker();
            txtEditora = new TextBox();
            nmPags = new NumericUpDown();
            txtDesc = new TextBox();
            btnInserir = new Button();
            ((System.ComponentModel.ISupportInitialize)nmPags).BeginInit();
            SuspendLayout();
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Location = new Point(12, 406);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(58, 15);
            lblDesc.TabIndex = 43;
            lblDesc.Text = "Descrição";
            // 
            // lblPgs
            // 
            lblPgs.AutoSize = true;
            lblPgs.Location = new Point(12, 346);
            lblPgs.Name = "lblPgs";
            lblPgs.Size = new Size(111, 15);
            lblPgs.TabIndex = 41;
            lblPgs.Text = "Numero de paginas";
            // 
            // lblEditora
            // 
            lblEditora.AutoSize = true;
            lblEditora.Location = new Point(12, 293);
            lblEditora.Name = "lblEditora";
            lblEditora.Size = new Size(44, 15);
            lblEditora.TabIndex = 39;
            lblEditora.Text = "Editora";
            // 
            // lblDtPublicacao
            // 
            lblDtPublicacao.AutoSize = true;
            lblDtPublicacao.Location = new Point(12, 237);
            lblDtPublicacao.Name = "lblDtPublicacao";
            lblDtPublicacao.Size = new Size(33, 15);
            lblDtPublicacao.TabIndex = 37;
            lblDtPublicacao.Text = "DtPb";
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.Location = new Point(12, 178);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(37, 15);
            lblAutor.TabIndex = 35;
            lblAutor.Text = "Autor";
            // 
            // lblSubtitulo
            // 
            lblSubtitulo.AutoSize = true;
            lblSubtitulo.Location = new Point(12, 121);
            lblSubtitulo.Name = "lblSubtitulo";
            lblSubtitulo.Size = new Size(55, 15);
            lblSubtitulo.TabIndex = 33;
            lblSubtitulo.Text = "Subtitulo";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 65);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 31;
            lblTitulo.Text = "Titulo";
            // 
            // lblIsbn
            // 
            lblIsbn.AutoSize = true;
            lblIsbn.Location = new Point(12, 10);
            lblIsbn.Name = "lblIsbn";
            lblIsbn.Size = new Size(29, 15);
            lblIsbn.TabIndex = 29;
            lblIsbn.Text = "Isbn";
            // 
            // txtIsbn
            // 
            txtIsbn.Location = new Point(12, 28);
            txtIsbn.Name = "txtIsbn";
            txtIsbn.Size = new Size(286, 23);
            txtIsbn.TabIndex = 45;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(12, 83);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(286, 23);
            txtTitulo.TabIndex = 46;
            // 
            // txtSubtitulo
            // 
            txtSubtitulo.Location = new Point(12, 139);
            txtSubtitulo.Name = "txtSubtitulo";
            txtSubtitulo.Size = new Size(286, 23);
            txtSubtitulo.TabIndex = 47;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(12, 196);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(286, 23);
            txtAutor.TabIndex = 48;
            // 
            // dtpPub
            // 
            dtpPub.Location = new Point(12, 255);
            dtpPub.Name = "dtpPub";
            dtpPub.Size = new Size(286, 23);
            dtpPub.TabIndex = 49;
            // 
            // txtEditora
            // 
            txtEditora.Location = new Point(12, 311);
            txtEditora.Name = "txtEditora";
            txtEditora.Size = new Size(286, 23);
            txtEditora.TabIndex = 50;
            // 
            // nmPags
            // 
            nmPags.Location = new Point(12, 364);
            nmPags.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmPags.Name = "nmPags";
            nmPags.Size = new Size(44, 23);
            nmPags.TabIndex = 51;
            nmPags.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtDesc
            // 
            txtDesc.Location = new Point(12, 424);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.Size = new Size(286, 101);
            txtDesc.TabIndex = 52;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(12, 532);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(287, 58);
            btnInserir.TabIndex = 53;
            btnInserir.Text = "Inserir livro";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // FormInserirLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 602);
            Controls.Add(btnInserir);
            Controls.Add(txtDesc);
            Controls.Add(nmPags);
            Controls.Add(txtEditora);
            Controls.Add(dtpPub);
            Controls.Add(txtAutor);
            Controls.Add(txtSubtitulo);
            Controls.Add(txtTitulo);
            Controls.Add(txtIsbn);
            Controls.Add(lblDesc);
            Controls.Add(lblPgs);
            Controls.Add(lblEditora);
            Controls.Add(lblDtPublicacao);
            Controls.Add(lblAutor);
            Controls.Add(lblSubtitulo);
            Controls.Add(lblTitulo);
            Controls.Add(lblIsbn);
            Name = "FormInserirLivros";
            Text = "FormInserirLivros";
            Load += FormInserirLivros_Load;
            ((System.ComponentModel.ISupportInitialize)nmPags).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDesc;
        private Label lblPgs;
        private Label lblEditora;
        private Label lblDtPublicacao;
        private Label lblAutor;
        private Label lblSubtitulo;
        private Label lblTitulo;
        private Label lblIsbn;
        private TextBox txtIsbn;
        private TextBox txtTitulo;
        private TextBox txtSubtitulo;
        private TextBox txtAutor;
        private DateTimePicker dtpPub;
        private TextBox txtEditora;
        private NumericUpDown nmPags;
        private TextBox txtDesc;
        private Button btnInserir;
    }
}