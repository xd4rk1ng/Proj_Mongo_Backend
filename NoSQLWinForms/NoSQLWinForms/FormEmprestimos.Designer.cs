namespace NoSQLWinForms
{
    partial class FormEmprestimos
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
            comboBox5 = new ComboBox();
            lblDtDev = new Label();
            comboBox4 = new ComboBox();
            lblDtEmp = new Label();
            comboBox3 = new ComboBox();
            lblLiv = new Label();
            comboBox2 = new ComboBox();
            lblEst = new Label();
            comboBox1 = new ComboBox();
            lblId = new Label();
            btnInserir = new Button();
            btnTerminar = new Button();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 529);
            listBox1.TabIndex = 3;
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Location = new Point(229, 264);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(190, 23);
            comboBox5.TabIndex = 22;
            // 
            // lblDtDev
            // 
            lblDtDev.AutoSize = true;
            lblDtDev.Location = new Point(229, 246);
            lblDtDev.Name = "lblDtDev";
            lblDtDev.Size = new Size(105, 15);
            lblDtDev.TabIndex = 21;
            lblDtDev.Text = "Data de devolução";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(229, 205);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(190, 23);
            comboBox4.TabIndex = 20;
            // 
            // lblDtEmp
            // 
            lblDtEmp.AutoSize = true;
            lblDtEmp.Location = new Point(229, 187);
            lblDtEmp.Name = "lblDtEmp";
            lblDtEmp.Size = new Size(114, 15);
            lblDtEmp.TabIndex = 19;
            lblDtEmp.Text = "Data de emprestimo";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(229, 143);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(190, 23);
            comboBox3.TabIndex = 18;
            // 
            // lblLiv
            // 
            lblLiv.AutoSize = true;
            lblLiv.Location = new Point(229, 125);
            lblLiv.Name = "lblLiv";
            lblLiv.Size = new Size(86, 15);
            lblLiv.TabIndex = 17;
            lblLiv.Text = "Nome do Livro";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(229, 87);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(190, 23);
            comboBox2.TabIndex = 16;
            // 
            // lblEst
            // 
            lblEst.AutoSize = true;
            lblEst.Location = new Point(229, 69);
            lblEst.Name = "lblEst";
            lblEst.Size = new Size(112, 15);
            lblEst.TabIndex = 15;
            lblEst.Text = "Nome do Estudante";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(229, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(190, 23);
            comboBox1.TabIndex = 14;
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(229, 14);
            lblId.Name = "lblId";
            lblId.Size = new Size(17, 15);
            lblId.TabIndex = 13;
            lblId.Text = "Id";
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(229, 471);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(190, 70);
            btnInserir.TabIndex = 23;
            btnInserir.Text = "Realizar novo emprestimo";
            btnInserir.UseVisualStyleBackColor = true;
            btnInserir.Click += btnInserir_Click;
            // 
            // btnTerminar
            // 
            btnTerminar.Location = new Point(229, 427);
            btnTerminar.Name = "btnTerminar";
            btnTerminar.Size = new Size(190, 38);
            btnTerminar.TabIndex = 24;
            btnTerminar.Text = "Terminar Empréstimo";
            btnTerminar.UseVisualStyleBackColor = true;
            btnTerminar.Click += btnTerminar_Click;
            // 
            // FormEmprestimos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 561);
            Controls.Add(btnTerminar);
            Controls.Add(btnInserir);
            Controls.Add(comboBox5);
            Controls.Add(lblDtDev);
            Controls.Add(comboBox4);
            Controls.Add(lblDtEmp);
            Controls.Add(comboBox3);
            Controls.Add(lblLiv);
            Controls.Add(comboBox2);
            Controls.Add(lblEst);
            Controls.Add(comboBox1);
            Controls.Add(lblId);
            Controls.Add(listBox1);
            Name = "FormEmprestimos";
            Text = "FormEmprestimos";
            Load += FormEmprestimos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ComboBox comboBox5;
        private Label lblDtDev;
        private ComboBox comboBox4;
        private Label lblDtEmp;
        private ComboBox comboBox3;
        private Label lblLiv;
        private ComboBox comboBox2;
        private Label lblEst;
        private ComboBox comboBox1;
        private Label lblId;
        private Button btnInserir;
        private Button btnTerminar;
    }
}