namespace Farmacia
{
    partial class frmTesteVariavel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTesteVariavel));
            this.btnMostrar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblMostrar = new System.Windows.Forms.Label();
            this.lblSair = new System.Windows.Forms.Label();
            this.btnbandeira = new System.Windows.Forms.Button();
            this.lblbandeira = new System.Windows.Forms.Label();
            this.btntrocar = new System.Windows.Forms.Button();
            this.lblAparecer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(41, 62);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 40);
            this.btnMostrar.TabIndex = 0;
            this.btnMostrar.Text = "&Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(41, 134);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 37);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sai&r";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblMostrar
            // 
            this.lblMostrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMostrar.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.lblMostrar.Location = new System.Drawing.Point(171, 134);
            this.lblMostrar.Name = "lblMostrar";
            this.lblMostrar.Size = new System.Drawing.Size(242, 37);
            this.lblMostrar.TabIndex = 2;
            this.lblMostrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMostrar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSair
            // 
            this.lblSair.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblSair.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSair.Location = new System.Drawing.Point(171, 62);
            this.lblSair.Name = "lblSair";
            this.lblSair.Size = new System.Drawing.Size(242, 40);
            this.lblSair.TabIndex = 3;
            this.lblSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnbandeira
            // 
            this.btnbandeira.Location = new System.Drawing.Point(41, 212);
            this.btnbandeira.Name = "btnbandeira";
            this.btnbandeira.Size = new System.Drawing.Size(90, 34);
            this.btnbandeira.TabIndex = 4;
            this.btnbandeira.Text = "Bandeira";
            this.btnbandeira.UseVisualStyleBackColor = true;
            this.btnbandeira.Click += new System.EventHandler(this.btnbandeira_Click);
            // 
            // lblbandeira
            // 
            this.lblbandeira.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblbandeira.Font = new System.Drawing.Font("Lucida Console", 11.25F);
            this.lblbandeira.Location = new System.Drawing.Point(171, 209);
            this.lblbandeira.Name = "lblbandeira";
            this.lblbandeira.Size = new System.Drawing.Size(242, 37);
            this.lblbandeira.TabIndex = 5;
            this.lblbandeira.Text = "False";
            this.lblbandeira.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btntrocar
            // 
            this.btntrocar.Location = new System.Drawing.Point(41, 288);
            this.btntrocar.Name = "btntrocar";
            this.btntrocar.Size = new System.Drawing.Size(181, 54);
            this.btntrocar.TabIndex = 6;
            this.btntrocar.Text = "Trocar";
            this.btntrocar.UseVisualStyleBackColor = true;
            this.btntrocar.Click += new System.EventHandler(this.btntrocar_Click);
            // 
            // lblAparecer
            // 
            this.lblAparecer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAparecer.Location = new System.Drawing.Point(323, 298);
            this.lblAparecer.Name = "lblAparecer";
            this.lblAparecer.Size = new System.Drawing.Size(29, 23);
            this.lblAparecer.TabIndex = 7;
            // 
            // frmTesteVariavel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 372);
            this.Controls.Add(this.lblAparecer);
            this.Controls.Add(this.btntrocar);
            this.Controls.Add(this.lblbandeira);
            this.Controls.Add(this.btnbandeira);
            this.Controls.Add(this.lblSair);
            this.Controls.Add(this.lblMostrar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnMostrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmTesteVariavel";
            this.Text = "Teste Variável";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblMostrar;
        private System.Windows.Forms.Label lblSair;
        private System.Windows.Forms.Button btnbandeira;
        private System.Windows.Forms.Label lblbandeira;
        private System.Windows.Forms.Button btntrocar;
        private System.Windows.Forms.Label lblAparecer;
    }
}