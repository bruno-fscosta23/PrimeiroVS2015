namespace Sistenge
{
    partial class frmMenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuPrincipal));
            this.btnFunci = new System.Windows.Forms.Button();
            this.btnProd = new System.Windows.Forms.Button();
            this.btnForn = new System.Windows.Forms.Button();
            this.btnUsua = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFunci
            // 
            this.btnFunci.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunci.Location = new System.Drawing.Point(3, 193);
            this.btnFunci.Name = "btnFunci";
            this.btnFunci.Size = new System.Drawing.Size(118, 64);
            this.btnFunci.TabIndex = 0;
            this.btnFunci.Text = "Gerenciar Funcionários";
            this.btnFunci.UseVisualStyleBackColor = true;
            // 
            // btnProd
            // 
            this.btnProd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProd.Location = new System.Drawing.Point(127, 193);
            this.btnProd.Name = "btnProd";
            this.btnProd.Size = new System.Drawing.Size(113, 64);
            this.btnProd.TabIndex = 1;
            this.btnProd.Text = "Gerenciar Produtos";
            this.btnProd.UseVisualStyleBackColor = true;
            // 
            // btnForn
            // 
            this.btnForn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnForn.Location = new System.Drawing.Point(246, 193);
            this.btnForn.Name = "btnForn";
            this.btnForn.Size = new System.Drawing.Size(126, 64);
            this.btnForn.TabIndex = 2;
            this.btnForn.Text = "Gerenciar Fornecedores";
            this.btnForn.UseVisualStyleBackColor = true;
            // 
            // btnUsua
            // 
            this.btnUsua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsua.Location = new System.Drawing.Point(378, 193);
            this.btnUsua.Name = "btnUsua";
            this.btnUsua.Size = new System.Drawing.Size(113, 64);
            this.btnUsua.TabIndex = 3;
            this.btnUsua.Text = "Gerenciar Usuários";
            this.btnUsua.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(497, 202);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(89, 46);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(211, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 269);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnUsua);
            this.Controls.Add(this.btnForn);
            this.Controls.Add(this.btnProd);
            this.Controls.Add(this.btnFunci);
            this.Name = "frmMenuPrincipal";
            this.Text = "MenuPrincipal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnFunci;
        private System.Windows.Forms.Button btnProd;
        private System.Windows.Forms.Button btnForn;
        private System.Windows.Forms.Button btnUsua;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}