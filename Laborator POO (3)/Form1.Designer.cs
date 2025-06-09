
namespace Laborator_POO__3_
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.emisie = new System.Windows.Forms.TextBox();
            this.cmc = new System.Windows.Forms.TextBox();
            this.an = new System.Windows.Forms.TextBox();
            this.calculeaza = new System.Windows.Forms.Button();
            this.rezultat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.norma = new System.Windows.Forms.ComboBox();
            this.darkmode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.butonLight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(269, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 54);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCUL TAXĂ ANUALĂ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Emisie CO2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Capacitate cilindrică:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Normă de poluare:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 376);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "An fabricare:";
            // 
            // emisie
            // 
            this.emisie.Location = new System.Drawing.Point(211, 183);
            this.emisie.Name = "emisie";
            this.emisie.Size = new System.Drawing.Size(173, 27);
            this.emisie.TabIndex = 5;
            // 
            // cmc
            // 
            this.cmc.Location = new System.Drawing.Point(211, 247);
            this.cmc.Name = "cmc";
            this.cmc.Size = new System.Drawing.Size(173, 27);
            this.cmc.TabIndex = 6;
            // 
            // an
            // 
            this.an.Location = new System.Drawing.Point(211, 373);
            this.an.Name = "an";
            this.an.Size = new System.Drawing.Size(173, 27);
            this.an.TabIndex = 8;
            // 
            // calculeaza
            // 
            this.calculeaza.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calculeaza.Location = new System.Drawing.Point(376, 474);
            this.calculeaza.Name = "calculeaza";
            this.calculeaza.Size = new System.Drawing.Size(254, 50);
            this.calculeaza.TabIndex = 9;
            this.calculeaza.Text = "Calculează";
            this.calculeaza.UseVisualStyleBackColor = true;
            this.calculeaza.Click += new System.EventHandler(this.calculeaza_Click);
            // 
            // rezultat
            // 
            this.rezultat.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rezultat.Location = new System.Drawing.Point(642, 234);
            this.rezultat.Multiline = true;
            this.rezultat.Name = "rezultat";
            this.rezultat.ReadOnly = true;
            this.rezultat.Size = new System.Drawing.Size(278, 66);
            this.rezultat.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(269, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(458, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "IMPORTANT! Vă rugăm să completați toate câmpurile prezente!";
            // 
            // norma
            // 
            this.norma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.norma.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.norma.FormattingEnabled = true;
            this.norma.Items.AddRange(new object[] {
            "Electric",
            "Hibrid",
            "Euro 6",
            "Euro 5",
            "Euro 4",
            "Euro 3",
            "Euro 2",
            "Euro 1",
            "Non-euro"});
            this.norma.Location = new System.Drawing.Point(211, 315);
            this.norma.Name = "norma";
            this.norma.Size = new System.Drawing.Size(173, 28);
            this.norma.TabIndex = 12;
            // 
            // darkmode
            // 
            this.darkmode.Location = new System.Drawing.Point(824, 24);
            this.darkmode.Name = "darkmode";
            this.darkmode.Size = new System.Drawing.Size(150, 32);
            this.darkmode.TabIndex = 13;
            this.darkmode.Text = "Mod întunecat";
            this.darkmode.UseVisualStyleBackColor = true;
            this.darkmode.Click += new System.EventHandler(this.darkmode_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(667, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 28);
            this.label7.TabIndex = 14;
            this.label7.Text = "Rezultatul va fi afișat aici";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // butonLight
            // 
            this.butonLight.Location = new System.Drawing.Point(12, 24);
            this.butonLight.Name = "butonLight";
            this.butonLight.Size = new System.Drawing.Size(150, 32);
            this.butonLight.TabIndex = 15;
            this.butonLight.Text = "Mod luminos";
            this.butonLight.UseVisualStyleBackColor = true;
            this.butonLight.Click += new System.EventHandler(this.butonLight_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 541);
            this.Controls.Add(this.butonLight);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.darkmode);
            this.Controls.Add(this.norma);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rezultat);
            this.Controls.Add(this.calculeaza);
            this.Controls.Add(this.an);
            this.Controls.Add(this.cmc);
            this.Controls.Add(this.emisie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Taxă anuală v1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
//            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emisie;
        private System.Windows.Forms.TextBox cmc;
        private System.Windows.Forms.TextBox an;
        private System.Windows.Forms.Button calculeaza;
        private System.Windows.Forms.TextBox rezultat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox norma;
        private System.Windows.Forms.Button darkmode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button butonLight;
    }
}

