namespace CalculadoraSimples
{
    partial class frmEstados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstados));
            this.btnCarregaEstados = new System.Windows.Forms.Button();
            this.cboEstados = new System.Windows.Forms.ComboBox();
            this.lblEstados = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.ltbLista = new System.Windows.Forms.ListBox();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnLimparLista = new System.Windows.Forms.Button();
            this.btnCarregaLabel = new System.Windows.Forms.Button();
            this.lblCarregarLabel = new System.Windows.Forms.Label();
            this.lblLista = new System.Windows.Forms.Label();
            this.grpSexo = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.lblRetorno = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbManha = new System.Windows.Forms.CheckBox();
            this.ckbTarde = new System.Windows.Forms.CheckBox();
            this.ckbNoite = new System.Windows.Forms.CheckBox();
            this.btnEscolha = new System.Windows.Forms.Button();
            this.grpSexo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCarregaEstados
            // 
            this.btnCarregaEstados.AutoSize = true;
            this.btnCarregaEstados.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaEstados.Location = new System.Drawing.Point(12, 119);
            this.btnCarregaEstados.Name = "btnCarregaEstados";
            this.btnCarregaEstados.Size = new System.Drawing.Size(137, 27);
            this.btnCarregaEstados.TabIndex = 0;
            this.btnCarregaEstados.Text = "Carregar Estados";
            this.btnCarregaEstados.UseVisualStyleBackColor = true;
            this.btnCarregaEstados.Click += new System.EventHandler(this.btnCarregaEstados_Click);
            // 
            // cboEstados
            // 
            this.cboEstados.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstados.FormattingEnabled = true;
            this.cboEstados.Location = new System.Drawing.Point(12, 45);
            this.cboEstados.Name = "cboEstados";
            this.cboEstados.Size = new System.Drawing.Size(121, 25);
            this.cboEstados.TabIndex = 1;
            this.cboEstados.SelectedIndexChanged += new System.EventHandler(this.cboEstados_SelectedIndexChanged);
            // 
            // lblEstados
            // 
            this.lblEstados.AutoSize = true;
            this.lblEstados.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstados.Location = new System.Drawing.Point(12, 12);
            this.lblEstados.Name = "lblEstados";
            this.lblEstados.Size = new System.Drawing.Size(67, 17);
            this.lblEstados.TabIndex = 2;
            this.lblEstados.Text = "Estados:";
            this.lblEstados.Click += new System.EventHandler(this.lblEstados_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(12, 159);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(118, 27);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar Estado";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // ltbLista
            // 
            this.ltbLista.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltbLista.FormattingEnabled = true;
            this.ltbLista.ItemHeight = 17;
            this.ltbLista.Location = new System.Drawing.Point(271, 25);
            this.ltbLista.Name = "ltbLista";
            this.ltbLista.Size = new System.Drawing.Size(120, 72);
            this.ltbLista.TabIndex = 4;
            this.ltbLista.SelectedIndexChanged += new System.EventHandler(this.ltbLista_SelectedIndexChanged);
            // 
            // btnLista
            // 
            this.btnLista.AutoSize = true;
            this.btnLista.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(271, 161);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(118, 27);
            this.btnLista.TabIndex = 5;
            this.btnLista.Text = "Carregar Lista";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click_1);
            // 
            // btnLimparLista
            // 
            this.btnLimparLista.AutoSize = true;
            this.btnLimparLista.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparLista.Location = new System.Drawing.Point(271, 200);
            this.btnLimparLista.Name = "btnLimparLista";
            this.btnLimparLista.Size = new System.Drawing.Size(105, 27);
            this.btnLimparLista.TabIndex = 6;
            this.btnLimparLista.Text = "Limpar Lista";
            this.btnLimparLista.UseVisualStyleBackColor = true;
            this.btnLimparLista.Click += new System.EventHandler(this.btnLimparLista_Click);
            // 
            // btnCarregaLabel
            // 
            this.btnCarregaLabel.AutoSize = true;
            this.btnCarregaLabel.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarregaLabel.Location = new System.Drawing.Point(149, 84);
            this.btnCarregaLabel.Name = "btnCarregaLabel";
            this.btnCarregaLabel.Size = new System.Drawing.Size(121, 27);
            this.btnCarregaLabel.TabIndex = 7;
            this.btnCarregaLabel.Text = "Carregar Label";
            this.btnCarregaLabel.UseVisualStyleBackColor = true;
            this.btnCarregaLabel.Click += new System.EventHandler(this.btnCarregaLabel_Click);
            // 
            // lblCarregarLabel
            // 
            this.lblCarregarLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCarregarLabel.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarregarLabel.Location = new System.Drawing.Point(149, 47);
            this.lblCarregarLabel.Name = "lblCarregarLabel";
            this.lblCarregarLabel.Size = new System.Drawing.Size(100, 21);
            this.lblCarregarLabel.TabIndex = 8;
            // 
            // lblLista
            // 
            this.lblLista.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLista.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLista.Location = new System.Drawing.Point(271, 119);
            this.lblLista.Name = "lblLista";
            this.lblLista.Size = new System.Drawing.Size(100, 21);
            this.lblLista.TabIndex = 9;
            // 
            // grpSexo
            // 
            this.grpSexo.Controls.Add(this.rdbFeminino);
            this.grpSexo.Controls.Add(this.rdbMasculino);
            this.grpSexo.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSexo.Location = new System.Drawing.Point(408, 15);
            this.grpSexo.Name = "grpSexo";
            this.grpSexo.Size = new System.Drawing.Size(95, 93);
            this.grpSexo.TabIndex = 10;
            this.grpSexo.TabStop = false;
            this.grpSexo.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(7, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(95, 18);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            this.rdbMasculino.CheckedChanged += new System.EventHandler(this.rdbMasculino_CheckedChanged);
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(7, 50);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(85, 18);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            this.rdbFeminino.CheckedChanged += new System.EventHandler(this.rdbFeminino_CheckedChanged);
            // 
            // lblRetorno
            // 
            this.lblRetorno.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRetorno.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetorno.Location = new System.Drawing.Point(408, 119);
            this.lblRetorno.Name = "lblRetorno";
            this.lblRetorno.Size = new System.Drawing.Size(89, 21);
            this.lblRetorno.TabIndex = 11;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ckbNoite);
            this.groupBox1.Controls.Add(this.ckbTarde);
            this.groupBox1.Controls.Add(this.ckbManha);
            this.groupBox1.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(522, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(94, 93);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha:";
            // 
            // ckbManha
            // 
            this.ckbManha.AutoSize = true;
            this.ckbManha.Location = new System.Drawing.Point(7, 19);
            this.ckbManha.Name = "ckbManha";
            this.ckbManha.Size = new System.Drawing.Size(74, 18);
            this.ckbManha.TabIndex = 0;
            this.ckbManha.Text = "Manhã";
            this.ckbManha.UseVisualStyleBackColor = true;
            // 
            // ckbTarde
            // 
            this.ckbTarde.AutoSize = true;
            this.ckbTarde.Location = new System.Drawing.Point(7, 40);
            this.ckbTarde.Name = "ckbTarde";
            this.ckbTarde.Size = new System.Drawing.Size(68, 18);
            this.ckbTarde.TabIndex = 1;
            this.ckbTarde.Text = "Tarde";
            this.ckbTarde.UseVisualStyleBackColor = true;
            // 
            // ckbNoite
            // 
            this.ckbNoite.AutoSize = true;
            this.ckbNoite.Location = new System.Drawing.Point(7, 64);
            this.ckbNoite.Name = "ckbNoite";
            this.ckbNoite.Size = new System.Drawing.Size(66, 18);
            this.ckbNoite.TabIndex = 2;
            this.ckbNoite.Text = "Noite";
            this.ckbNoite.UseVisualStyleBackColor = true;
            // 
            // btnEscolha
            // 
            this.btnEscolha.AutoSize = true;
            this.btnEscolha.Font = new System.Drawing.Font("Kristen ITC", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEscolha.Location = new System.Drawing.Point(408, 159);
            this.btnEscolha.Name = "btnEscolha";
            this.btnEscolha.Size = new System.Drawing.Size(95, 27);
            this.btnEscolha.TabIndex = 13;
            this.btnEscolha.Text = "Escolha";
            this.btnEscolha.UseVisualStyleBackColor = true;
            this.btnEscolha.Click += new System.EventHandler(this.btnEscolha_Click);
            // 
            // frmEstados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 231);
            this.Controls.Add(this.btnEscolha);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRetorno);
            this.Controls.Add(this.grpSexo);
            this.Controls.Add(this.lblLista);
            this.Controls.Add(this.lblCarregarLabel);
            this.Controls.Add(this.btnCarregaLabel);
            this.Controls.Add(this.btnLimparLista);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.ltbLista);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblEstados);
            this.Controls.Add(this.cboEstados);
            this.Controls.Add(this.btnCarregaEstados);
            this.Font = new System.Drawing.Font("Britannic Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstados";
            this.Text = "Programa de Escolhas";
            this.Load += new System.EventHandler(this.frmEstados_Load);
            this.grpSexo.ResumeLayout(false);
            this.grpSexo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregaEstados;
        private System.Windows.Forms.ComboBox cboEstados;
        private System.Windows.Forms.Label lblEstados;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.ListBox ltbLista;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnLimparLista;
        private System.Windows.Forms.Button btnCarregaLabel;
        private System.Windows.Forms.Label lblCarregarLabel;
        private System.Windows.Forms.Label lblLista;
        private System.Windows.Forms.GroupBox grpSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblRetorno;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbNoite;
        private System.Windows.Forms.CheckBox ckbTarde;
        private System.Windows.Forms.CheckBox ckbManha;
        private System.Windows.Forms.Button btnEscolha;
    }
}