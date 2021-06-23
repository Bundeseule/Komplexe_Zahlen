namespace Komplexe_Zahlen
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.bSchliessen = new System.Windows.Forms.Button();
            this.bPlus = new System.Windows.Forms.Button();
            this.bMinus = new System.Windows.Forms.Button();
            this.bMultiplikation = new System.Windows.Forms.Button();
            this.bDividieren = new System.Windows.Forms.Button();
            this.tbRe1 = new System.Windows.Forms.TextBox();
            this.tbIm1 = new System.Windows.Forms.TextBox();
            this.tbRe2 = new System.Windows.Forms.TextBox();
            this.tbIm2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelErgebnis = new System.Windows.Forms.Label();
            this.lErg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bSchliessen
            // 
            this.bSchliessen.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSchliessen.Location = new System.Drawing.Point(1093, 284);
            this.bSchliessen.Name = "bSchliessen";
            this.bSchliessen.Size = new System.Drawing.Size(134, 70);
            this.bSchliessen.TabIndex = 0;
            this.bSchliessen.Text = "Beenden";
            this.bSchliessen.UseVisualStyleBackColor = true;
            this.bSchliessen.Click += new System.EventHandler(this.bSchliessen_Click);
            // 
            // bPlus
            // 
            this.bPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPlus.Location = new System.Drawing.Point(452, 30);
            this.bPlus.Name = "bPlus";
            this.bPlus.Size = new System.Drawing.Size(70, 70);
            this.bPlus.TabIndex = 1;
            this.bPlus.Text = "+";
            this.bPlus.UseVisualStyleBackColor = true;
            this.bPlus.Click += new System.EventHandler(this.bPlus_Click);
            // 
            // bMinus
            // 
            this.bMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMinus.Location = new System.Drawing.Point(452, 106);
            this.bMinus.Name = "bMinus";
            this.bMinus.Size = new System.Drawing.Size(70, 70);
            this.bMinus.TabIndex = 2;
            this.bMinus.Text = "-";
            this.bMinus.UseVisualStyleBackColor = true;
            this.bMinus.Click += new System.EventHandler(this.bMinus_Click);
            // 
            // bMultiplikation
            // 
            this.bMultiplikation.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMultiplikation.Location = new System.Drawing.Point(452, 182);
            this.bMultiplikation.Name = "bMultiplikation";
            this.bMultiplikation.Size = new System.Drawing.Size(70, 70);
            this.bMultiplikation.TabIndex = 3;
            this.bMultiplikation.Text = "*";
            this.bMultiplikation.UseVisualStyleBackColor = true;
            this.bMultiplikation.Click += new System.EventHandler(this.bMultiplikation_Click);
            // 
            // bDividieren
            // 
            this.bDividieren.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDividieren.Location = new System.Drawing.Point(452, 258);
            this.bDividieren.Name = "bDividieren";
            this.bDividieren.Size = new System.Drawing.Size(70, 70);
            this.bDividieren.TabIndex = 4;
            this.bDividieren.Text = "/";
            this.bDividieren.UseVisualStyleBackColor = true;
            // 
            // tbRe1
            // 
            this.tbRe1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRe1.Location = new System.Drawing.Point(28, 171);
            this.tbRe1.Name = "tbRe1";
            this.tbRe1.Size = new System.Drawing.Size(100, 38);
            this.tbRe1.TabIndex = 5;
            // 
            // tbIm1
            // 
            this.tbIm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIm1.Location = new System.Drawing.Point(254, 171);
            this.tbIm1.Name = "tbIm1";
            this.tbIm1.Size = new System.Drawing.Size(100, 38);
            this.tbIm1.TabIndex = 6;
            // 
            // tbRe2
            // 
            this.tbRe2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbRe2.Location = new System.Drawing.Point(586, 171);
            this.tbRe2.Name = "tbRe2";
            this.tbRe2.Size = new System.Drawing.Size(100, 38);
            this.tbRe2.TabIndex = 7;
            // 
            // tbIm2
            // 
            this.tbIm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIm2.Location = new System.Drawing.Point(811, 171);
            this.tbIm2.Name = "tbIm2";
            this.tbIm2.Size = new System.Drawing.Size(100, 38);
            this.tbIm2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(134, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "re1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(360, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = "im1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(692, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 31);
            this.label3.TabIndex = 11;
            this.label3.Text = "re2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(917, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 31);
            this.label4.TabIndex = 12;
            this.label4.Text = "im2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(976, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "=";
            // 
            // labelErgebnis
            // 
            this.labelErgebnis.AutoSize = true;
            this.labelErgebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErgebnis.Location = new System.Drawing.Point(1012, 174);
            this.labelErgebnis.Name = "labelErgebnis";
            this.labelErgebnis.Size = new System.Drawing.Size(0, 31);
            this.labelErgebnis.TabIndex = 14;
            // 
            // lErg
            // 
            this.lErg.AutoSize = true;
            this.lErg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lErg.Location = new System.Drawing.Point(1012, 174);
            this.lErg.Name = "lErg";
            this.lErg.Size = new System.Drawing.Size(86, 31);
            this.lErg.TabIndex = 15;
            this.lErg.Text = "label6";
            this.lErg.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 366);
            this.Controls.Add(this.lErg);
            this.Controls.Add(this.labelErgebnis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIm2);
            this.Controls.Add(this.tbRe2);
            this.Controls.Add(this.tbIm1);
            this.Controls.Add(this.tbRe1);
            this.Controls.Add(this.bDividieren);
            this.Controls.Add(this.bMultiplikation);
            this.Controls.Add(this.bMinus);
            this.Controls.Add(this.bPlus);
            this.Controls.Add(this.bSchliessen);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bSchliessen;
        private System.Windows.Forms.Button bPlus;
        private System.Windows.Forms.Button bMinus;
        private System.Windows.Forms.Button bMultiplikation;
        private System.Windows.Forms.Button bDividieren;
        private System.Windows.Forms.TextBox tbRe1;
        private System.Windows.Forms.TextBox tbIm1;
        private System.Windows.Forms.TextBox tbRe2;
        private System.Windows.Forms.TextBox tbIm2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelErgebnis;
        private System.Windows.Forms.Label lErg;
    }
}

