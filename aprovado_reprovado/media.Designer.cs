namespace aprovado_reprovado
{
    partial class media
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbln1 = new System.Windows.Forms.Label();
            this.lbln2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtn1 = new System.Windows.Forms.TextBox();
            this.txtn2 = new System.Windows.Forms.TextBox();
            this.txtn3 = new System.Windows.Forms.TextBox();
            this.txtn4 = new System.Windows.Forms.TextBox();
            this.bto_somar = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.bto_sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbln1
            // 
            this.lbln1.AutoSize = true;
            this.lbln1.Location = new System.Drawing.Point(36, 32);
            this.lbln1.Name = "lbln1";
            this.lbln1.Size = new System.Drawing.Size(22, 15);
            this.lbln1.TabIndex = 0;
            this.lbln1.Text = "N1";
            this.lbln1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbln2
            // 
            this.lbln2.AutoSize = true;
            this.lbln2.Location = new System.Drawing.Point(290, 32);
            this.lbln2.Name = "lbln2";
            this.lbln2.Size = new System.Drawing.Size(22, 15);
            this.lbln2.TabIndex = 1;
            this.lbln2.Text = "N2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "N3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(719, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "N4";
            // 
            // txtn1
            // 
            this.txtn1.Location = new System.Drawing.Point(36, 74);
            this.txtn1.Name = "txtn1";
            this.txtn1.Size = new System.Drawing.Size(100, 23);
            this.txtn1.TabIndex = 4;
            // 
            // txtn2
            // 
            this.txtn2.Location = new System.Drawing.Point(245, 74);
            this.txtn2.Name = "txtn2";
            this.txtn2.Size = new System.Drawing.Size(100, 23);
            this.txtn2.TabIndex = 5;
            // 
            // txtn3
            // 
            this.txtn3.Location = new System.Drawing.Point(462, 74);
            this.txtn3.Name = "txtn3";
            this.txtn3.Size = new System.Drawing.Size(100, 23);
            this.txtn3.TabIndex = 6;
            // 
            // txtn4
            // 
            this.txtn4.Location = new System.Drawing.Point(657, 74);
            this.txtn4.Name = "txtn4";
            this.txtn4.Size = new System.Drawing.Size(100, 23);
            this.txtn4.TabIndex = 7;
            // 
            // bto_somar
            // 
            this.bto_somar.Location = new System.Drawing.Point(695, 261);
            this.bto_somar.Name = "bto_somar";
            this.bto_somar.Size = new System.Drawing.Size(75, 23);
            this.bto_somar.TabIndex = 8;
            this.bto_somar.Text = "Somar";
            this.bto_somar.UseVisualStyleBackColor = true;
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.BackColor = System.Drawing.Color.Cyan;
            this.lbl_resultado.Location = new System.Drawing.Point(245, 285);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(238, 156);
            this.lbl_resultado.TabIndex = 9;
            this.lbl_resultado.Text = "0";
        
            // 
            // bto_sair
            // 
            this.bto_sair.Location = new System.Drawing.Point(695, 314);
            this.bto_sair.Name = "bto_sair";
            this.bto_sair.Size = new System.Drawing.Size(75, 23);
            this.bto_sair.TabIndex = 10;
            this.bto_sair.Text = "Sair";
            this.bto_sair.UseVisualStyleBackColor = true;

            // 
            // media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bto_sair);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.bto_somar);
            this.Controls.Add(this.txtn4);
            this.Controls.Add(this.txtn3);
            this.Controls.Add(this.txtn2);
            this.Controls.Add(this.txtn1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbln2);
            this.Controls.Add(this.lbln1);
            this.Name = "media";
            this.Text = "Form1";
        
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbln1;
        private Label lbln2;
        private Label label3;
        private Label label4;
        private TextBox txtn1;
        private TextBox txtn2;
        private TextBox txtn3;
        private TextBox txtn4;
        private Button bto_somar;
        private Label lbl_resultado;
        private Button bto_sair;
    }
}