namespace VİZE_FİNAL_PROGRAMI._
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblHarf = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butHesapla = new System.Windows.Forms.Button();
            this.textFinal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textVize = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 442);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "vize final hisaplama";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblHarf);
            this.panel2.Controls.Add(this.lblOrt);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(26, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(421, 211);
            this.panel2.TabIndex = 1;
            // 
            // lblHarf
            // 
            this.lblHarf.AutoSize = true;
            this.lblHarf.Location = new System.Drawing.Point(128, 74);
            this.lblHarf.Name = "lblHarf";
            this.lblHarf.Size = new System.Drawing.Size(31, 19);
            this.lblHarf.TabIndex = 5;
            this.lblHarf.Text = "\"  \"";
            this.lblHarf.Click += new System.EventHandler(this.label6_Click);
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Location = new System.Drawing.Point(128, 32);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(31, 19);
            this.lblOrt.TabIndex = 4;
            this.lblOrt.Text = "\"  \"";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Harf Notu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ortalama Not:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.butHesapla);
            this.panel1.Controls.Add(this.textFinal);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textVize);
            this.panel1.Location = new System.Drawing.Point(25, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 180);
            this.panel1.TabIndex = 0;
            // 
            // butHesapla
            // 
            this.butHesapla.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHesapla.Location = new System.Drawing.Point(133, 107);
            this.butHesapla.Name = "butHesapla";
            this.butHesapla.Size = new System.Drawing.Size(149, 28);
            this.butHesapla.TabIndex = 4;
            this.butHesapla.Text = "Hesapla";
            this.butHesapla.UseVisualStyleBackColor = true;
            this.butHesapla.Click += new System.EventHandler(this.butHesapla_Click);
            // 
            // textFinal
            // 
            this.textFinal.Location = new System.Drawing.Point(133, 59);
            this.textFinal.Name = "textFinal";
            this.textFinal.Size = new System.Drawing.Size(149, 27);
            this.textFinal.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Notu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vize Notu:";
            // 
            // textVize
            // 
            this.textVize.Location = new System.Drawing.Point(133, 20);
            this.textVize.Name = "textVize";
            this.textVize.Size = new System.Drawing.Size(149, 27);
            this.textVize.TabIndex = 0;
            this.textVize.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 466);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textVize;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button butHesapla;
        private System.Windows.Forms.TextBox textFinal;
        private System.Windows.Forms.Label lblHarf;
        private System.Windows.Forms.Label lblOrt;
    }
}

