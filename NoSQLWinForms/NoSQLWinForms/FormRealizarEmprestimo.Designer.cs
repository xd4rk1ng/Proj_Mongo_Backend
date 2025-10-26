namespace NoSQLWinForms
{
    partial class FormRealizarEmprestimo
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
            btnInserir = new Button();
            lblEst = new Label();
            lblTitulo = new Label();
            dateTimePicker1 = new DateTimePicker();
            lblDtEmprestimo = new Label();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // btnInserir
            // 
            btnInserir.Location = new Point(14, 251);
            btnInserir.Name = "btnInserir";
            btnInserir.Size = new Size(287, 58);
            btnInserir.TabIndex = 27;
            btnInserir.Text = "Realizar emprestimo";
            btnInserir.UseVisualStyleBackColor = true;
            // 
            // lblEst
            // 
            lblEst.AutoSize = true;
            lblEst.Location = new Point(12, 10);
            lblEst.Name = "lblEst";
            lblEst.Size = new Size(112, 15);
            lblEst.TabIndex = 28;
            lblEst.Text = "Nome do Estudante";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(12, 62);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(37, 15);
            lblTitulo.TabIndex = 30;
            lblTitulo.Text = "Titulo";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(14, 132);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(287, 23);
            dateTimePicker1.TabIndex = 51;
            // 
            // lblDtEmprestimo
            // 
            lblDtEmprestimo.AutoSize = true;
            lblDtEmprestimo.Location = new Point(14, 114);
            lblDtEmprestimo.Name = "lblDtEmprestimo";
            lblDtEmprestimo.Size = new Size(33, 15);
            lblDtEmprestimo.TabIndex = 50;
            lblDtEmprestimo.Text = "DtPb";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(12, 28);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(289, 23);
            comboBox2.TabIndex = 29;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 80);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(289, 23);
            comboBox1.TabIndex = 31;
            // 
            // FormRealizarEmprestimo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(314, 321);
            Controls.Add(dateTimePicker1);
            Controls.Add(lblDtEmprestimo);
            Controls.Add(comboBox1);
            Controls.Add(lblTitulo);
            Controls.Add(comboBox2);
            Controls.Add(lblEst);
            Controls.Add(btnInserir);
            Name = "FormRealizarEmprestimo";
            Text = "FormRealizarEmprestimo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserir;
        private Label lblEst;
        private Label lblTitulo;
        private DateTimePicker dateTimePicker1;
        private Label lblDtEmprestimo;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}