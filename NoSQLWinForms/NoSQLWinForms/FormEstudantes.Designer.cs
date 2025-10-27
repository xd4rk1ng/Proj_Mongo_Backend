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
            cmbId = new ComboBox();
            cmbNome = new ComboBox();
            lblNome = new Label();
            lblIdade = new Label();
            cmbCurso = new ComboBox();
            lblCurso = new Label();
            cmbEmail = new ComboBox();
            lblEmail = new Label();
            btnInserir = new Button();
            nmIdade = new NumericUpDown();
            btnFilters = new Button();
            btnClean = new Button();
            ((System.ComponentModel.ISupportInitialize)nmIdade).BeginInit();
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
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
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
            // cmbId
            // 
            cmbId.FormattingEnabled = true;
            cmbId.Location = new Point(232, 27);
            cmbId.Name = "cmbId";
            cmbId.Size = new Size(190, 23);
            cmbId.TabIndex = 4;            
            // 
            // cmbNome
            // 
            cmbNome.FormattingEnabled = true;
            cmbNome.Location = new Point(232, 82);
            cmbNome.Name = "cmbNome";
            cmbNome.Size = new Size(190, 23);
            cmbNome.TabIndex = 6;
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
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(232, 120);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(36, 15);
            lblIdade.TabIndex = 7;
            lblIdade.Text = "Idade";
            // 
            // cmbCurso
            // 
            cmbCurso.FormattingEnabled = true;
            cmbCurso.Location = new Point(232, 200);
            cmbCurso.Name = "cmbCurso";
            cmbCurso.Size = new Size(190, 23);
            cmbCurso.TabIndex = 10;
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
            // cmbEmail
            // 
            cmbEmail.FormattingEnabled = true;
            cmbEmail.Location = new Point(232, 259);
            cmbEmail.Name = "cmbEmail";
            cmbEmail.Size = new Size(190, 23);
            cmbEmail.TabIndex = 12;
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
            // nmIdade
            // 
            nmIdade.Location = new Point(232, 138);
            nmIdade.Name = "nmIdade";
            nmIdade.Size = new Size(68, 23);
            nmIdade.TabIndex = 14;
            // 
            // btnFilters
            // 
            btnFilters.BackColor = SystemColors.ActiveCaption;
            btnFilters.Location = new Point(232, 288);
            btnFilters.Name = "btnFilters";
            btnFilters.Size = new Size(56, 53);
            btnFilters.TabIndex = 15;
            btnFilters.Text = "Aplicar Filtros";
            btnFilters.UseVisualStyleBackColor = false;
            btnFilters.Click += btnFilters_Click;
            // 
            // btnClean
            // 
            btnClean.BackColor = Color.IndianRed;
            btnClean.Location = new Point(294, 288);
            btnClean.Name = "btnClean";
            btnClean.Size = new Size(56, 53);
            btnClean.TabIndex = 16;
            btnClean.Text = "Limpar Filtros";
            btnClean.UseVisualStyleBackColor = false;
            btnClean.Click += btnClean_Click;
            // 
            // FormEstudantes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 561);
            Controls.Add(btnClean);
            Controls.Add(btnFilters);
            Controls.Add(nmIdade);
            Controls.Add(btnInserir);
            Controls.Add(cmbEmail);
            Controls.Add(lblEmail);
            Controls.Add(cmbCurso);
            Controls.Add(lblCurso);
            Controls.Add(lblIdade);
            Controls.Add(cmbNome);
            Controls.Add(lblNome);
            Controls.Add(cmbId);
            Controls.Add(lblId);
            Controls.Add(listBox1);
            Name = "FormEstudantes";
            Text = "FormEstudantes";
            Load += FormEstudantes_Load;
            ((System.ComponentModel.ISupportInitialize)nmIdade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Label lblId;
        private ComboBox cmbId;
        private ComboBox cmbNome;
        private Label lblNome;
        private Label lblIdade;
        private ComboBox cmbCurso;
        private Label lblCurso;
        private ComboBox cmbEmail;
        private Label lblEmail;
        private Button btnInserir;
        private NumericUpDown nmIdade;
        private Button btnFilters;
        private Button btnClean;
    }
}