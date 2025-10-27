namespace NoSQLWinForms
{
    partial class FormInserirEstudante
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
            lblEmail = new Label();
            lblCurso = new Label();
            lblIdade = new Label();
            lblNome = new Label();
            txtNome = new TextBox();
            nmIdade = new NumericUpDown();
            txtCurso = new TextBox();
            txtEmail = new TextBox();
            btnInserir = new Button();
            ((System.ComponentModel.ISupportInitialize)nmIdade).BeginInit();
            SuspendLayout();
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(12, 187);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 21;
            lblEmail.Text = "Email";
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(12, 121);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(38, 15);
            lblCurso.TabIndex = 19;
            lblCurso.Text = "Curso";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(12, 66);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 17;
            lblIdade.Text = "Idade";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(12, 10);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 15;
            lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(12, 34);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(287, 23);
            txtNome.TabIndex = 22;
            // 
            // nmIdade
            // 
            nmIdade.Location = new Point(12, 84);
            nmIdade.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nmIdade.Name = "nmIdade";
            nmIdade.Size = new Size(54, 23);
            nmIdade.TabIndex = 23;
            nmIdade.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // txtCurso
            // 
            txtCurso.Location = new Point(12, 139);
            txtCurso.Name = "txtCurso";
            txtCurso.Size = new Size(287, 23);
            txtCurso.TabIndex = 24;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 205);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(287, 23);
            txtEmail.TabIndex = 25;
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(12, 254);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(287, 58);
            btnInserir.TabIndex = 26;
            btnInserir.Text = "Inserir estudante";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // FormInserirEstudante
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 321);
            Controls.Add(btnInserir);
            Controls.Add(txtEmail);
            Controls.Add(txtCurso);
            Controls.Add(nmIdade);
            Controls.Add(txtNome);
            Controls.Add(lblEmail);
            Controls.Add(lblCurso);
            Controls.Add(lblIdade);
            Controls.Add(lblNome);
            Name = "FormInserirEstudante";
            Text = "FormInserirEstudante";
            ((System.ComponentModel.ISupportInitialize)nmIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEmail;
        private Label lblCurso;
        private Label lblIdade;
        private Label lblNome;
        private TextBox txtNome;
        private NumericUpDown nmIdade;
        private TextBox txtCurso;
        private TextBox txtEmail;
        private Button btnInserir;
    }
}