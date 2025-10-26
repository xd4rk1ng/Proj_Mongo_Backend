namespace NoSQLWinForms
{
    partial class FormEstudantes
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
            listBox1 = new ListBox();
            lblId = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            lblNome = new Label();
            comboBox3 = new ComboBox();
            lblIdade = new Label();
            comboBox4 = new ComboBox();
            lblCurso = new Label();
            comboBox5 = new ComboBox();
            lblEmail = new Label();
            btnInserir = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 529);
            listBox1.TabIndex = 1;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(232, 9);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 3;
            lblId.Text = "Id";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(232, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 23);
            comboBox2.TabIndex = 6;
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(232, 64);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 5;
            lblNome.Text = "Nome";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(232, 138);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 23);
            comboBox3.TabIndex = 8;
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(232, 120);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 7;
            lblIdade.Text = "Idade";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(232, 200);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(190, 23);
            comboBox4.TabIndex = 10;
            // 
            // lblCurso
            // 
            lblCurso.AutoSize = true;
            lblCurso.Location = new Point(232, 182);
            lblCurso.Name = "lblCurso";
            lblCurso.Size = new Size(38, 15);
            lblCurso.TabIndex = 9;
            lblCurso.Text = "Curso";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(232, 259);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(190, 23);
            comboBox5.TabIndex = 12;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(232, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(232, 471);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(190, 70);
            btnInserir.TabIndex = 13;
            btnInserir.Text = "Inserir novo estudante";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // FormEstudantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 561);
            Controls.Add(btnInserir);
            Controls.Add(comboBox5);
            Controls.Add(lblEmail);
            Controls.Add(comboBox4);
            Controls.Add(lblCurso);
            Controls.Add(comboBox3);
            Controls.Add(lblIdade);
            Controls.Add(comboBox2);
            Controls.Add(lblNome);
            Controls.Add(comboBox1);
            Controls.Add(lblId);
            Controls.Add(listBox1);
            Name = "FormEstudantes";
            Text = "FormEstudantes";
            Load += FormEstudantes_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblId;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblNome;
        private ComboBox comboBox3;
        private Label lblIdade;
        private ComboBox comboBox4;
        private Label lblCurso;
        private ComboBox comboBox5;
        private Label lblEmail;
        private Button btnInserir;
    }
}