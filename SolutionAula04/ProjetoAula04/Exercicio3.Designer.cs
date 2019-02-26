namespace ProjetoAula04
{
    partial class Exercicio3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercicio3));
            this.btn5 = new System.Windows.Forms.Button();
            this.btn10 = new System.Windows.Forms.Button();
            this.btn15 = new System.Windows.Forms.Button();
            this.btn20 = new System.Windows.Forms.Button();
            this.lblSala = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.lblNovoSal = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblCalculeSala = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(220, 107);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(137, 26);
            this.btn5.TabIndex = 0;
            this.btn5.Text = "Aumento 5%";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn10
            // 
            this.btn10.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn10.Location = new System.Drawing.Point(220, 146);
            this.btn10.Name = "btn10";
            this.btn10.Size = new System.Drawing.Size(137, 26);
            this.btn10.TabIndex = 1;
            this.btn10.Text = "Aumento 10%";
            this.btn10.UseVisualStyleBackColor = true;
            this.btn10.Click += new System.EventHandler(this.btn10_Click);
            // 
            // btn15
            // 
            this.btn15.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn15.Location = new System.Drawing.Point(220, 192);
            this.btn15.Name = "btn15";
            this.btn15.Size = new System.Drawing.Size(137, 26);
            this.btn15.TabIndex = 2;
            this.btn15.Text = "Aumento 15%";
            this.btn15.UseVisualStyleBackColor = true;
            this.btn15.Click += new System.EventHandler(this.btn15_Click);
            // 
            // btn20
            // 
            this.btn20.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn20.Location = new System.Drawing.Point(220, 240);
            this.btn20.Name = "btn20";
            this.btn20.Size = new System.Drawing.Size(137, 26);
            this.btn20.TabIndex = 3;
            this.btn20.Text = "Aumento 20%";
            this.btn20.UseVisualStyleBackColor = true;
            this.btn20.Click += new System.EventHandler(this.btn20_Click);
            // 
            // lblSala
            // 
            this.lblSala.AutoSize = true;
            this.lblSala.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSala.Location = new System.Drawing.Point(10, 107);
            this.lblSala.Name = "lblSala";
            this.lblSala.Size = new System.Drawing.Size(73, 21);
            this.lblSala.TabIndex = 4;
            this.lblSala.Text = "Salário: ";
            // 
            // txtSala
            // 
            this.txtSala.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSala.Location = new System.Drawing.Point(78, 100);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(100, 28);
            this.txtSala.TabIndex = 5;
            // 
            // lblNovoSal
            // 
            this.lblNovoSal.AutoSize = true;
            this.lblNovoSal.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNovoSal.Location = new System.Drawing.Point(24, 313);
            this.lblNovoSal.Name = "lblNovoSal";
            this.lblNovoSal.Size = new System.Drawing.Size(137, 21);
            this.lblNovoSal.TabIndex = 6;
            this.lblNovoSal.Text = "Novo Salário =  ";
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResult.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(142, 313);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(100, 21);
            this.lblResult.TabIndex = 7;
            // 
            // lblCalculeSala
            // 
            this.lblCalculeSala.AutoSize = true;
            this.lblCalculeSala.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalculeSala.Location = new System.Drawing.Point(62, 27);
            this.lblCalculeSala.Name = "lblCalculeSala";
            this.lblCalculeSala.Size = new System.Drawing.Size(259, 38);
            this.lblCalculeSala.TabIndex = 8;
            this.lblCalculeSala.Text = "Calcule seu Salário";
            this.lblCalculeSala.Click += new System.EventHandler(this.lblCalculeSala_Click);
            // 
            // Exercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 373);
            this.Controls.Add(this.lblCalculeSala);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblNovoSal);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.lblSala);
            this.Controls.Add(this.btn20);
            this.Controls.Add(this.btn15);
            this.Controls.Add(this.btn10);
            this.Controls.Add(this.btn5);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exercicio3";
            this.Text = "Exercicio3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn10;
        private System.Windows.Forms.Button btn15;
        private System.Windows.Forms.Button btn20;
        private System.Windows.Forms.Label lblSala;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label lblNovoSal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblCalculeSala;
    }
}