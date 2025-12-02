namespace _11.sql_ile_birleştirme
{
    partial class frmistatistik
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbltoplampersonel = new System.Windows.Forms.Label();
            this.lblevli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblbekar = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsehir = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbltoplammaas = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblortalamamaas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel sayısı :";
            // 
            // lbltoplampersonel
            // 
            this.lbltoplampersonel.AutoSize = true;
            this.lbltoplampersonel.Location = new System.Drawing.Point(234, 46);
            this.lbltoplampersonel.Name = "lbltoplampersonel";
            this.lbltoplampersonel.Size = new System.Drawing.Size(24, 28);
            this.lbltoplampersonel.TabIndex = 1;
            this.lbltoplampersonel.Text = "0";
            // 
            // lblevli
            // 
            this.lblevli.AutoSize = true;
            this.lblevli.Location = new System.Drawing.Point(236, 91);
            this.lblevli.Name = "lblevli";
            this.lblevli.Size = new System.Drawing.Size(24, 28);
            this.lblevli.TabIndex = 2;
            this.lblevli.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Evli personel sayısı :";
            // 
            // lblbekar
            // 
            this.lblbekar.AutoSize = true;
            this.lblbekar.Location = new System.Drawing.Point(236, 135);
            this.lblbekar.Name = "lblbekar";
            this.lblbekar.Size = new System.Drawing.Size(24, 28);
            this.lblbekar.TabIndex = 4;
            this.lblbekar.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(218, 28);
            this.label6.TabIndex = 5;
            this.label6.Text = "Bekar personel sayısı :";
            // 
            // lblsehir
            // 
            this.lblsehir.AutoSize = true;
            this.lblsehir.Location = new System.Drawing.Point(236, 181);
            this.lblsehir.Name = "lblsehir";
            this.lblsehir.Size = new System.Drawing.Size(24, 28);
            this.lblsehir.TabIndex = 6;
            this.lblsehir.Text = "0";
            this.lblsehir.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(103, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 28);
            this.label8.TabIndex = 7;
            this.label8.Text = "Şehir sayısı :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(81, 224);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 28);
            this.label9.TabIndex = 8;
            this.label9.Text = "Toplam maaş :";
            // 
            // lbltoplammaas
            // 
            this.lbltoplammaas.AutoSize = true;
            this.lbltoplammaas.Location = new System.Drawing.Point(236, 224);
            this.lbltoplammaas.Name = "lbltoplammaas";
            this.lbltoplammaas.Size = new System.Drawing.Size(24, 28);
            this.lbltoplammaas.TabIndex = 9;
            this.lbltoplammaas.Text = "0";
            this.lbltoplammaas.Click += new System.EventHandler(this.label10_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 262);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 28);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ortalama maaş :";
            // 
            // lblortalamamaas
            // 
            this.lblortalamamaas.AutoSize = true;
            this.lblortalamamaas.Location = new System.Drawing.Point(236, 262);
            this.lblortalamamaas.Name = "lblortalamamaas";
            this.lblortalamamaas.Size = new System.Drawing.Size(24, 28);
            this.lblortalamamaas.TabIndex = 9;
            this.lblortalamamaas.Text = "0";
            this.lblortalamamaas.Click += new System.EventHandler(this.label10_Click);
            // 
            // frmistatistik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 380);
            this.Controls.Add(this.lblortalamamaas);
            this.Controls.Add(this.lbltoplammaas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblsehir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblbekar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblevli);
            this.Controls.Add(this.lbltoplampersonel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmistatistik";
            this.Text = "frmistatistik";
            this.Load += new System.EventHandler(this.frmistatistik_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbltoplampersonel;
        private System.Windows.Forms.Label lblevli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblbekar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblsehir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbltoplammaas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblortalamamaas;
    }
}