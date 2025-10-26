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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox5 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox6 = new TextBox();
            btnInserir = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
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
            lblPgs.Size = new Size(39, 15);
            lblPgs.TabIndex = 41;
            lblPgs.Text = "nPags";
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(286, 23);
            textBox1.TabIndex = 45;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 83);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(286, 23);
            textBox2.TabIndex = 46;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 139);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(286, 23);
            textBox3.TabIndex = 47;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(12, 196);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(286, 23);
            textBox4.TabIndex = 48;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 255);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(286, 23);
            dateTimePicker1.TabIndex = 49;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 311);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(286, 23);
            textBox5.TabIndex = 50;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 364);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(44, 23);
            numericUpDown1.TabIndex = 51;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 424);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(286, 101);
            textBox6.TabIndex = 52;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(12, 532);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(287, 58);
            btnInserir.TabIndex = 53;
            btnInserir.Text = "Inserir livro";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // FormInserirLivros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 602);
            Controls.Add(btnInserir);
            Controls.Add(textBox6);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox5;
        private NumericUpDown numericUpDown1;
        private TextBox textBox6;
        private Button btnInserir;
    }
}