namespace Taschenrechner
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
            this.Anzeige = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.Komma = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.Plus = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.Multiplikation = new System.Windows.Forms.Button();
            this.Minus = new System.Windows.Forms.Button();
            this.Rechnen = new System.Windows.Forms.Button();
            this.Error = new System.Windows.Forms.Label();
            this.Binär = new System.Windows.Forms.Button();
            this.ZusatzAnzeige = new System.Windows.Forms.Label();
            this.Fakultät = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Anzeige
            // 
            this.Anzeige.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Anzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Anzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anzeige.Location = new System.Drawing.Point(12, 25);
            this.Anzeige.MinimumSize = new System.Drawing.Size(500, 30);
            this.Anzeige.Name = "Anzeige";
            this.Anzeige.Size = new System.Drawing.Size(500, 30);
            this.Anzeige.TabIndex = 0;
            this.Anzeige.Text = "0";
            this.Anzeige.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(60, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "7";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(112, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(60, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 39);
            this.button3.TabIndex = 3;
            this.button3.Text = "4";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 178);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 39);
            this.button4.TabIndex = 4;
            this.button4.Text = "6";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(164, 133);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 39);
            this.button5.TabIndex = 5;
            this.button5.Text = "9";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(112, 133);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 39);
            this.button6.TabIndex = 6;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(164, 223);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 39);
            this.button7.TabIndex = 7;
            this.button7.Text = "3";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.Button_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(112, 223);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 39);
            this.button8.TabIndex = 8;
            this.button8.Text = "2";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Button_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(60, 223);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 39);
            this.button9.TabIndex = 9;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.Button_Click);
            // 
            // Komma
            // 
            this.Komma.Location = new System.Drawing.Point(164, 268);
            this.Komma.Name = "Komma";
            this.Komma.Size = new System.Drawing.Size(46, 39);
            this.Komma.TabIndex = 10;
            this.Komma.Text = ",";
            this.Komma.UseVisualStyleBackColor = true;
            this.Komma.Click += new System.EventHandler(this.Button_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(112, 268);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 39);
            this.button11.TabIndex = 11;
            this.button11.Text = "0";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.Button_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(60, 268);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 39);
            this.button12.TabIndex = 12;
            this.button12.Text = "DEL";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.Form1_Load);
            // 
            // Plus
            // 
            this.Plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus.Location = new System.Drawing.Point(244, 133);
            this.Plus.Name = "Plus";
            this.Plus.Size = new System.Drawing.Size(46, 39);
            this.Plus.TabIndex = 13;
            this.Plus.Text = "+";
            this.Plus.UseVisualStyleBackColor = true;
            this.Plus.Click += new System.EventHandler(this.RO_Click);
            // 
            // Division
            // 
            this.Division.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Division.Location = new System.Drawing.Point(296, 178);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(46, 39);
            this.Division.TabIndex = 14;
            this.Division.Text = "/";
            this.Division.UseVisualStyleBackColor = true;
            this.Division.Click += new System.EventHandler(this.RO_Click);
            // 
            // Multiplikation
            // 
            this.Multiplikation.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multiplikation.Location = new System.Drawing.Point(244, 178);
            this.Multiplikation.Name = "Multiplikation";
            this.Multiplikation.Size = new System.Drawing.Size(46, 39);
            this.Multiplikation.TabIndex = 15;
            this.Multiplikation.Text = "*";
            this.Multiplikation.UseVisualStyleBackColor = true;
            this.Multiplikation.Click += new System.EventHandler(this.RO_Click);
            // 
            // Minus
            // 
            this.Minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus.Location = new System.Drawing.Point(296, 133);
            this.Minus.Name = "Minus";
            this.Minus.Size = new System.Drawing.Size(46, 39);
            this.Minus.TabIndex = 16;
            this.Minus.Text = "-";
            this.Minus.UseVisualStyleBackColor = true;
            this.Minus.Click += new System.EventHandler(this.RO_Click);
            // 
            // Rechnen
            // 
            this.Rechnen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rechnen.Location = new System.Drawing.Point(244, 223);
            this.Rechnen.Name = "Rechnen";
            this.Rechnen.Size = new System.Drawing.Size(98, 39);
            this.Rechnen.TabIndex = 17;
            this.Rechnen.Text = "=";
            this.Rechnen.UseVisualStyleBackColor = true;
            this.Rechnen.Click += new System.EventHandler(this.Ergebnis);
            // 
            // Error
            // 
            this.Error.AutoSize = true;
            this.Error.Location = new System.Drawing.Point(302, 313);
            this.Error.Name = "Error";
            this.Error.Size = new System.Drawing.Size(0, 13);
            this.Error.TabIndex = 18;
            // 
            // Binär
            // 
            this.Binär.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Binär.Location = new System.Drawing.Point(348, 133);
            this.Binär.Name = "Binär";
            this.Binär.Size = new System.Drawing.Size(79, 39);
            this.Binär.TabIndex = 19;
            this.Binär.Text = "Binär";
            this.Binär.UseVisualStyleBackColor = true;
            this.Binär.Click += new System.EventHandler(this.Binär_Click);
            // 
            // ZusatzAnzeige
            // 
            this.ZusatzAnzeige.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ZusatzAnzeige.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ZusatzAnzeige.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ZusatzAnzeige.Location = new System.Drawing.Point(12, 55);
            this.ZusatzAnzeige.MinimumSize = new System.Drawing.Size(500, 10);
            this.ZusatzAnzeige.Name = "ZusatzAnzeige";
            this.ZusatzAnzeige.Size = new System.Drawing.Size(500, 26);
            this.ZusatzAnzeige.TabIndex = 20;
            this.ZusatzAnzeige.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Fakultät
            // 
            this.Fakultät.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fakultät.Location = new System.Drawing.Point(348, 178);
            this.Fakultät.Name = "Fakultät";
            this.Fakultät.Size = new System.Drawing.Size(79, 39);
            this.Fakultät.TabIndex = 21;
            this.Fakultät.Text = "!";
            this.Fakultät.UseVisualStyleBackColor = true;
            this.Fakultät.Click += new System.EventHandler(this.Fakultät_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 357);
            this.Controls.Add(this.Fakultät);
            this.Controls.Add(this.ZusatzAnzeige);
            this.Controls.Add(this.Binär);
            this.Controls.Add(this.Error);
            this.Controls.Add(this.Rechnen);
            this.Controls.Add(this.Minus);
            this.Controls.Add(this.Multiplikation);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Plus);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.Komma);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Anzeige);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Anzeige;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button Komma;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button Plus;
        private System.Windows.Forms.Button Division;
        private System.Windows.Forms.Button Multiplikation;
        private System.Windows.Forms.Button Minus;
        private System.Windows.Forms.Button Rechnen;
        private System.Windows.Forms.Label Error;
        private System.Windows.Forms.Button Binär;
        private System.Windows.Forms.Label ZusatzAnzeige;
        private System.Windows.Forms.Button Fakultät;
    }
}

