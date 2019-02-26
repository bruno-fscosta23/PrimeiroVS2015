namespace ProjetoAula04
{
    partial class Exercicio
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
            this.btnIdade = new System.Windows.Forms.Button();
            this.pnlExer1 = new System.Windows.Forms.Panel();
            this.lblResc = new System.Windows.Forms.Label();
            this.txtAnoAtual = new System.Windows.Forms.TextBox();
            this.txtAnoNasc = new System.Windows.Forms.TextBox();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblAnoAtual = new System.Windows.Forms.Label();
            this.lblAnoNasc = new System.Windows.Forms.Label();
            this.pnlExer2 = new System.Windows.Forms.Panel();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.btnArea = new System.Windows.Forms.Button();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblAreaResut = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblA = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblRescX1 = new System.Windows.Forms.Label();
            this.lblRescX2 = new System.Windows.Forms.Label();
            this.pnlExer1.SuspendLayout();
            this.pnlExer2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIdade
            // 
            this.btnIdade.Location = new System.Drawing.Point(260, 69);
            this.btnIdade.Name = "btnIdade";
            this.btnIdade.Size = new System.Drawing.Size(75, 23);
            this.btnIdade.TabIndex = 0;
            this.btnIdade.Text = "Idade";
            this.btnIdade.UseVisualStyleBackColor = true;
            this.btnIdade.Click += new System.EventHandler(this.btnIdade_Click);
            // 
            // pnlExer1
            // 
            this.pnlExer1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlExer1.Controls.Add(this.lblResc);
            this.pnlExer1.Controls.Add(this.txtAnoAtual);
            this.pnlExer1.Controls.Add(this.txtAnoNasc);
            this.pnlExer1.Controls.Add(this.lblIdade);
            this.pnlExer1.Controls.Add(this.lblAnoAtual);
            this.pnlExer1.Controls.Add(this.lblAnoNasc);
            this.pnlExer1.Controls.Add(this.btnIdade);
            this.pnlExer1.Location = new System.Drawing.Point(29, 12);
            this.pnlExer1.Name = "pnlExer1";
            this.pnlExer1.Size = new System.Drawing.Size(470, 111);
            this.pnlExer1.TabIndex = 1;
            // 
            // lblResc
            // 
            this.lblResc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResc.Location = new System.Drawing.Point(309, 31);
            this.lblResc.Name = "lblResc";
            this.lblResc.Size = new System.Drawing.Size(25, 23);
            this.lblResc.TabIndex = 6;
            // 
            // txtAnoAtual
            // 
            this.txtAnoAtual.Location = new System.Drawing.Point(117, 67);
            this.txtAnoAtual.Name = "txtAnoAtual";
            this.txtAnoAtual.Size = new System.Drawing.Size(100, 20);
            this.txtAnoAtual.TabIndex = 5;
            // 
            // txtAnoNasc
            // 
            this.txtAnoNasc.Location = new System.Drawing.Point(117, 34);
            this.txtAnoNasc.Name = "txtAnoNasc";
            this.txtAnoNasc.Size = new System.Drawing.Size(100, 20);
            this.txtAnoNasc.TabIndex = 4;
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Location = new System.Drawing.Point(257, 34);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(46, 13);
            this.lblIdade.TabIndex = 3;
            this.lblIdade.Text = "Idade = ";
            this.lblIdade.Click += new System.EventHandler(this.lblIdade_Click);
            // 
            // lblAnoAtual
            // 
            this.lblAnoAtual.AutoSize = true;
            this.lblAnoAtual.Location = new System.Drawing.Point(24, 74);
            this.lblAnoAtual.Name = "lblAnoAtual";
            this.lblAnoAtual.Size = new System.Drawing.Size(55, 13);
            this.lblAnoAtual.TabIndex = 2;
            this.lblAnoAtual.Text = "Ano atual:";
            // 
            // lblAnoNasc
            // 
            this.lblAnoNasc.AutoSize = true;
            this.lblAnoNasc.Location = new System.Drawing.Point(24, 34);
            this.lblAnoNasc.Name = "lblAnoNasc";
            this.lblAnoNasc.Size = new System.Drawing.Size(86, 13);
            this.lblAnoNasc.TabIndex = 1;
            this.lblAnoNasc.Text = "Ano nascimento:";
            // 
            // pnlExer2
            // 
            this.pnlExer2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlExer2.Controls.Add(this.lblAreaResut);
            this.pnlExer2.Controls.Add(this.txtValor);
            this.pnlExer2.Controls.Add(this.btnArea);
            this.pnlExer2.Controls.Add(this.lblArea);
            this.pnlExer2.Controls.Add(this.lblValor);
            this.pnlExer2.Location = new System.Drawing.Point(29, 142);
            this.pnlExer2.Name = "pnlExer2";
            this.pnlExer2.Size = new System.Drawing.Size(470, 110);
            this.pnlExer2.TabIndex = 2;
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(47, 51);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 20);
            this.txtValor.TabIndex = 3;
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(260, 51);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(75, 23);
            this.btnArea.TabIndex = 2;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click);
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(257, 22);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(32, 13);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Area:";
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(44, 22);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(69, 13);
            this.lblValor.TabIndex = 0;
            this.lblValor.Text = "Valor do raio:";
            // 
            // lblAreaResut
            // 
            this.lblAreaResut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAreaResut.Location = new System.Drawing.Point(290, 15);
            this.lblAreaResut.Name = "lblAreaResut";
            this.lblAreaResut.Size = new System.Drawing.Size(118, 25);
            this.lblAreaResut.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.lblRescX2);
            this.panel1.Controls.Add(this.lblRescX1);
            this.panel1.Controls.Add(this.lblX2);
            this.panel1.Controls.Add(this.lblX1);
            this.panel1.Controls.Add(this.btnCalc);
            this.panel1.Controls.Add(this.txtC);
            this.panel1.Controls.Add(this.txtB);
            this.panel1.Controls.Add(this.txtA);
            this.panel1.Controls.Add(this.lblC);
            this.panel1.Controls.Add(this.lblB);
            this.panel1.Controls.Add(this.lblA);
            this.panel1.Location = new System.Drawing.Point(29, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(470, 110);
            this.panel1.TabIndex = 3;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Location = new System.Drawing.Point(24, 23);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(14, 13);
            this.lblA.TabIndex = 0;
            this.lblA.Text = "A";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Location = new System.Drawing.Point(24, 45);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(14, 13);
            this.lblB.TabIndex = 1;
            this.lblB.Text = "B";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Location = new System.Drawing.Point(24, 70);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(14, 13);
            this.lblC.TabIndex = 2;
            this.lblC.Text = "C";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(44, 16);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 20);
            this.txtA.TabIndex = 3;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(44, 42);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 20);
            this.txtB.TabIndex = 4;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(44, 67);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 20);
            this.txtC.TabIndex = 5;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(195, 40);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 6;
            this.btnCalc.Text = "Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // lblX1
            // 
            this.lblX1.AutoSize = true;
            this.lblX1.Location = new System.Drawing.Point(306, 23);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(32, 13);
            this.lblX1.TabIndex = 7;
            this.lblX1.Text = "X1 = ";
            // 
            // lblX2
            // 
            this.lblX2.AutoSize = true;
            this.lblX2.Location = new System.Drawing.Point(306, 70);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(32, 13);
            this.lblX2.TabIndex = 8;
            this.lblX2.Text = "X2 = ";
            // 
            // lblRescX1
            // 
            this.lblRescX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRescX1.Location = new System.Drawing.Point(344, 18);
            this.lblRescX1.Name = "lblRescX1";
            this.lblRescX1.Size = new System.Drawing.Size(100, 23);
            this.lblRescX1.TabIndex = 9;
            // 
            // lblRescX2
            // 
            this.lblRescX2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRescX2.Location = new System.Drawing.Point(344, 64);
            this.lblRescX2.Name = "lblRescX2";
            this.lblRescX2.Size = new System.Drawing.Size(100, 23);
            this.lblRescX2.TabIndex = 10;
            // 
            // Exercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 394);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlExer2);
            this.Controls.Add(this.pnlExer1);
            this.Name = "Exercicio";
            this.Text = "Exercicio";
            this.pnlExer1.ResumeLayout(false);
            this.pnlExer1.PerformLayout();
            this.pnlExer2.ResumeLayout(false);
            this.pnlExer2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnIdade;
        private System.Windows.Forms.Panel pnlExer1;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblAnoAtual;
        private System.Windows.Forms.Label lblAnoNasc;
        private System.Windows.Forms.TextBox txtAnoAtual;
        private System.Windows.Forms.TextBox txtAnoNasc;
        private System.Windows.Forms.Panel pnlExer2;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblResc;
        private System.Windows.Forms.Label lblAreaResut;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRescX2;
        private System.Windows.Forms.Label lblRescX1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
    }
}