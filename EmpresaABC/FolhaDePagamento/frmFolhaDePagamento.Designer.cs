namespace FolhaDePagamento
{
    partial class frmFolhaDePagamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFolhaDePagamento));
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.ckbPlanoSaude = new System.Windows.Forms.CheckBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.cboCLube = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalaFolha = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblSalaLiquido = new System.Windows.Forms.Label();
            this.txtSalaLiquido = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalaFolha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(13, 56);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(122, 28);
            this.dtpDataFolha.TabIndex = 0;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(13, 30);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(122, 21);
            this.lblDataFolha.TabIndex = 1;
            this.lblDataFolha.Text = "Data da Folha:";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(13, 100);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(65, 21);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(13, 126);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(100, 28);
            this.txtSalario.TabIndex = 3;
            // 
            // ckbPlanoSaude
            // 
            this.ckbPlanoSaude.AutoSize = true;
            this.ckbPlanoSaude.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbPlanoSaude.Location = new System.Drawing.Point(13, 160);
            this.ckbPlanoSaude.Name = "ckbPlanoSaude";
            this.ckbPlanoSaude.Size = new System.Drawing.Size(99, 21);
            this.ckbPlanoSaude.TabIndex = 4;
            this.ckbPlanoSaude.Text = "Plano Saúde";
            this.ckbPlanoSaude.UseVisualStyleBackColor = true;
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(13, 194);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(130, 21);
            this.lblClubeLazer.TabIndex = 5;
            this.lblClubeLazer.Text = "Clube de Lazer:";
            // 
            // cboCLube
            // 
            this.cboCLube.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCLube.FormattingEnabled = true;
            this.cboCLube.Location = new System.Drawing.Point(13, 224);
            this.cboCLube.Name = "cboCLube";
            this.cboCLube.Size = new System.Drawing.Size(135, 25);
            this.cboCLube.TabIndex = 6;
            this.cboCLube.SelectedIndexChanged += new System.EventHandler(this.cboCLube_SelectedIndexChanged);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(175, 47);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(130, 37);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalaFolha
            // 
            this.lblSalaFolha.AutoSize = true;
            this.lblSalaFolha.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaFolha.Location = new System.Drawing.Point(152, 108);
            this.lblSalaFolha.Name = "lblSalaFolha";
            this.lblSalaFolha.Size = new System.Drawing.Size(111, 21);
            this.lblSalaFolha.TabIndex = 8;
            this.lblSalaFolha.Text = "Salário Folha:";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImposto.Location = new System.Drawing.Point(152, 145);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(153, 21);
            this.lblImposto.TabIndex = 9;
            this.lblImposto.Text = "Imposto de Renda:";
            // 
            // lblSalaLiquido
            // 
            this.lblSalaLiquido.AutoSize = true;
            this.lblSalaLiquido.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalaLiquido.Location = new System.Drawing.Point(152, 187);
            this.lblSalaLiquido.Name = "lblSalaLiquido";
            this.lblSalaLiquido.Size = new System.Drawing.Size(125, 21);
            this.lblSalaLiquido.TabIndex = 10;
            this.lblSalaLiquido.Text = "Salário Liquido:";
            // 
            // txtSalaLiquido
            // 
            this.txtSalaLiquido.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaLiquido.Location = new System.Drawing.Point(306, 180);
            this.txtSalaLiquido.Name = "txtSalaLiquido";
            this.txtSalaLiquido.Size = new System.Drawing.Size(100, 28);
            this.txtSalaLiquido.TabIndex = 13;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImpostoRenda.Location = new System.Drawing.Point(306, 139);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(100, 28);
            this.txtImpostoRenda.TabIndex = 12;
            // 
            // txtSalaFolha
            // 
            this.txtSalaFolha.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalaFolha.Location = new System.Drawing.Point(306, 101);
            this.txtSalaFolha.Name = "txtSalaFolha";
            this.txtSalaFolha.Size = new System.Drawing.Size(100, 28);
            this.txtSalaFolha.TabIndex = 11;
            // 
            // frmFolhaDePagamento
            // 
            this.AcceptButton = this.btnCalcular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 292);
            this.Controls.Add(this.txtSalaLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalaFolha);
            this.Controls.Add(this.lblSalaLiquido);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblSalaFolha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cboCLube);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.ckbPlanoSaude);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.dtpDataFolha);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFolhaDePagamento";
            this.Text = "Folha De Pagamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.CheckBox ckbPlanoSaude;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.ComboBox cboCLube;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalaFolha;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblSalaLiquido;
        private System.Windows.Forms.TextBox txtSalaLiquido;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalaFolha;
    }
}