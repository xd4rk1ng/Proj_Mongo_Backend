namespace NoSQLWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnFormEstudantes = new Button();
            btnFormLivros = new Button();
            btnFormEmprestimos = new Button();
            SuspendLayout();
            // 
            // btnFormEstudantes
            // 
            btnFormEstudantes.Location = new Point(52, 21);
            btnFormEstudantes.Name = "btnFormEstudantes";
            btnFormEstudantes.Size = new Size(180, 80);
            btnFormEstudantes.TabIndex = 0;
            btnFormEstudantes.Text = "Estudantes";
            btnFormEstudantes.UseVisualStyleBackColor = true;
            btnFormEstudantes.Click += button1_Click;
            // 
            // btnFormLivros
            // 
            btnFormLivros.Location = new Point(52, 142);
            btnFormLivros.Name = "btnFormLivros";
            btnFormLivros.Size = new Size(180, 80);
            btnFormLivros.TabIndex = 1;
            btnFormLivros.Text = "Livros";
            btnFormLivros.UseVisualStyleBackColor = true;
            btnFormLivros.Click += btnFormLivros_Click;
            // 
            // btnFormEmprestimos
            // 
            btnFormEmprestimos.Location = new Point(52, 261);
            btnFormEmprestimos.Name = "btnFormEmprestimos";
            btnFormEmprestimos.Size = new Size(180, 80);
            btnFormEmprestimos.TabIndex = 2;
            btnFormEmprestimos.Text = "Emprestimos";
            btnFormEmprestimos.UseVisualStyleBackColor = true;
            btnFormEmprestimos.Click += btnFormEmprestimos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 361);
            Controls.Add(btnFormEmprestimos);
            Controls.Add(btnFormLivros);
            Controls.Add(btnFormEstudantes);
            Name = "Form1";
            Text = "Livraria Escolar SeRui";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnFormEstudantes;
        private Button btnFormLivros;
        private Button btnFormEmprestimos;
    }
}
