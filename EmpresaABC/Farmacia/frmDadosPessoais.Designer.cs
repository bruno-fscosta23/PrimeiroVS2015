namespace Farmacia
{
    partial class frmDadosPessoais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDadosPessoais));
            this.cboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblDadosPessoais = new System.Windows.Forms.Label();
            this.labNome = new System.Windows.Forms.Label();
            this.labCargo = new System.Windows.Forms.Label();
            this.labTelefone = new System.Windows.Forms.Label();
            this.labDept = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btbVoltar = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.lblTipo = new System.Windows.Forms.Label();
            this.ckbCrianca = new System.Windows.Forms.CheckBox();
            this.ckbJovem = new System.Windows.Forms.CheckBox();
            this.ckbAdulto = new System.Windows.Forms.CheckBox();
            this.lblEscolha = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cboDepartamento
            // 
            this.cboDepartamento.FormattingEnabled = true;
            this.cboDepartamento.Items.AddRange(new object[] {
            "Recursos Humano",
            "Secretaria",
            "Administração Central",
            "Almoxarifado"});
            this.cboDepartamento.Location = new System.Drawing.Point(169, 230);
            this.cboDepartamento.Name = "cboDepartamento";
            this.cboDepartamento.Size = new System.Drawing.Size(210, 21);
            this.cboDepartamento.TabIndex = 3;
            // 
            // lblDadosPessoais
            // 
            this.lblDadosPessoais.AutoSize = true;
            this.lblDadosPessoais.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosPessoais.Location = new System.Drawing.Point(89, 9);
            this.lblDadosPessoais.Name = "lblDadosPessoais";
            this.lblDadosPessoais.Size = new System.Drawing.Size(259, 47);
            this.lblDadosPessoais.TabIndex = 1;
            this.lblDadosPessoais.Text = "Dados Pessoais";
            this.lblDadosPessoais.Click += new System.EventHandler(this.lblDadosPessoais_Click);
            // 
            // labNome
            // 
            this.labNome.AutoSize = true;
            this.labNome.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNome.Location = new System.Drawing.Point(23, 78);
            this.labNome.Name = "labNome";
            this.labNome.Size = new System.Drawing.Size(67, 25);
            this.labNome.TabIndex = 2;
            this.labNome.Text = "Nome:";
            // 
            // labCargo
            // 
            this.labCargo.AutoSize = true;
            this.labCargo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labCargo.Location = new System.Drawing.Point(23, 119);
            this.labCargo.Name = "labCargo";
            this.labCargo.Size = new System.Drawing.Size(67, 25);
            this.labCargo.TabIndex = 3;
            this.labCargo.Text = "Cargo:";
            // 
            // labTelefone
            // 
            this.labTelefone.AutoSize = true;
            this.labTelefone.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTelefone.Location = new System.Drawing.Point(23, 170);
            this.labTelefone.Name = "labTelefone";
            this.labTelefone.Size = new System.Drawing.Size(87, 25);
            this.labTelefone.TabIndex = 4;
            this.labTelefone.Text = "Telefone:";
            // 
            // labDept
            // 
            this.labDept.AutoSize = true;
            this.labDept.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDept.Location = new System.Drawing.Point(23, 221);
            this.labDept.Name = "labDept";
            this.labDept.Size = new System.Drawing.Size(137, 25);
            this.labDept.TabIndex = 5;
            this.labDept.Text = "Departamento:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(169, 78);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(210, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtCargo
            // 
            this.txtCargo.Location = new System.Drawing.Point(169, 128);
            this.txtCargo.MaxLength = 50;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(210, 20);
            this.txtCargo.TabIndex = 1;
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(169, 185);
            this.txtTelefone.MaxLength = 20;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(111, 20);
            this.txtTelefone.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastrar.Location = new System.Drawing.Point(29, 412);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(131, 49);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btbVoltar
            // 
            this.btbVoltar.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btbVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btbVoltar.Image")));
            this.btbVoltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btbVoltar.Location = new System.Drawing.Point(238, 412);
            this.btbVoltar.Name = "btbVoltar";
            this.btbVoltar.Size = new System.Drawing.Size(159, 49);
            this.btbVoltar.TabIndex = 5;
            this.btbVoltar.Text = "&Voltar";
            this.btbVoltar.UseVisualStyleBackColor = true;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(26, 275);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 6;
            this.lblSexo.Text = "Sexo:";
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(86, 275);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 7;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(159, 275);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 8;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(28, 310);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(31, 13);
            this.lblTipo.TabIndex = 9;
            this.lblTipo.Text = "Tipo:";
            // 
            // ckbCrianca
            // 
            this.ckbCrianca.AutoSize = true;
            this.ckbCrianca.Location = new System.Drawing.Point(65, 309);
            this.ckbCrianca.Name = "ckbCrianca";
            this.ckbCrianca.Size = new System.Drawing.Size(62, 17);
            this.ckbCrianca.TabIndex = 10;
            this.ckbCrianca.Text = "Criança";
            this.ckbCrianca.UseVisualStyleBackColor = true;
            // 
            // ckbJovem
            // 
            this.ckbJovem.AutoSize = true;
            this.ckbJovem.Location = new System.Drawing.Point(65, 332);
            this.ckbJovem.Name = "ckbJovem";
            this.ckbJovem.Size = new System.Drawing.Size(57, 17);
            this.ckbJovem.TabIndex = 11;
            this.ckbJovem.Text = "Jovem";
            this.ckbJovem.UseVisualStyleBackColor = true;
            // 
            // ckbAdulto
            // 
            this.ckbAdulto.AutoSize = true;
            this.ckbAdulto.Location = new System.Drawing.Point(65, 356);
            this.ckbAdulto.Name = "ckbAdulto";
            this.ckbAdulto.Size = new System.Drawing.Size(56, 17);
            this.ckbAdulto.TabIndex = 12;
            this.ckbAdulto.Text = "Adulto";
            this.ckbAdulto.UseVisualStyleBackColor = true;
            // 
            // lblEscolha
            // 
            this.lblEscolha.AutoSize = true;
            this.lblEscolha.Location = new System.Drawing.Point(190, 310);
            this.lblEscolha.Name = "lblEscolha";
            this.lblEscolha.Size = new System.Drawing.Size(48, 13);
            this.lblEscolha.TabIndex = 13;
            this.lblEscolha.Text = "Escolha:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Calça",
            "Camisa",
            "Gravata",
            "Saia",
            "Blusa",
            "Bermuda",
            "Camiseta",
            "Jaqueta"});
            this.listBox1.Location = new System.Drawing.Point(244, 310);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 14;
            // 
            // frmDadosPessoais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 473);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblEscolha);
            this.Controls.Add(this.ckbAdulto);
            this.Controls.Add(this.ckbJovem);
            this.Controls.Add(this.ckbCrianca);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFeminino);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.btbVoltar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.labDept);
            this.Controls.Add(this.labTelefone);
            this.Controls.Add(this.labCargo);
            this.Controls.Add(this.labNome);
            this.Controls.Add(this.lblDadosPessoais);
            this.Controls.Add(this.cboDepartamento);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDadosPessoais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Farmácia - Dados Pessoais";
            this.Load += new System.EventHandler(this.frmDadosPessoais_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDepartamento;
        private System.Windows.Forms.Label lblDadosPessoais;
        private System.Windows.Forms.Label labNome;
        private System.Windows.Forms.Label labCargo;
        private System.Windows.Forms.Label labTelefone;
        private System.Windows.Forms.Label labDept;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btbVoltar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.CheckBox ckbCrianca;
        private System.Windows.Forms.CheckBox ckbJovem;
        private System.Windows.Forms.CheckBox ckbAdulto;
        private System.Windows.Forms.Label lblEscolha;
        private System.Windows.Forms.ListBox listBox1;
    }
}