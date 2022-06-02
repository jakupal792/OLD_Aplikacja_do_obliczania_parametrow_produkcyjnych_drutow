
namespace Druty
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOblicz = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtD0 = new System.Windows.Forms.TextBox();
            this.txtD1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtD0ciagadlo = new System.Windows.Forms.TextBox();
            this.txtDciagadlo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLamb = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOblicz
            // 
            this.btnOblicz.Location = new System.Drawing.Point(118, 281);
            this.btnOblicz.Name = "btnOblicz";
            this.btnOblicz.Size = new System.Drawing.Size(154, 60);
            this.btnOblicz.TabIndex = 0;
            this.btnOblicz.Text = "Oblicz";
            this.btnOblicz.UseVisualStyleBackColor = true;
            this.btnOblicz.Click += new System.EventHandler(this.btnOblicz_Click);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(118, 395);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(154, 22);
            this.txtF.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(170, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Fc [MPa]";
            // 
            // txtR
            // 
            this.txtR.Location = new System.Drawing.Point(149, 128);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(84, 22);
            this.txtR.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(146, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wytrzymałość na \r\nrozciąganie R [MPa]";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtD0
            // 
            this.txtD0.Location = new System.Drawing.Point(149, 178);
            this.txtD0.Name = "txtD0";
            this.txtD0.Size = new System.Drawing.Size(84, 22);
            this.txtD0.TabIndex = 5;
            // 
            // txtD1
            // 
            this.txtD1.Location = new System.Drawing.Point(149, 223);
            this.txtD1.Name = "txtD1";
            this.txtD1.Size = new System.Drawing.Size(84, 22);
            this.txtD1.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "D0 [mm]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(146, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "D1 [mm]";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(538, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 60);
            this.button1.TabIndex = 9;
            this.button1.Text = "Oblicz";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtD0ciagadlo
            // 
            this.txtD0ciagadlo.Location = new System.Drawing.Point(569, 139);
            this.txtD0ciagadlo.Name = "txtD0ciagadlo";
            this.txtD0ciagadlo.Size = new System.Drawing.Size(84, 22);
            this.txtD0ciagadlo.TabIndex = 10;
            // 
            // txtDciagadlo
            // 
            this.txtDciagadlo.Location = new System.Drawing.Point(569, 395);
            this.txtDciagadlo.Name = "txtDciagadlo";
            this.txtDciagadlo.Size = new System.Drawing.Size(84, 22);
            this.txtDciagadlo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(585, 363);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "D [mm]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(566, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "D0 [mm]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(566, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "λ pśr.";
            // 
            // txtLamb
            // 
            this.txtLamb.Location = new System.Drawing.Point(569, 202);
            this.txtLamb.Name = "txtLamb";
            this.txtLamb.Size = new System.Drawing.Size(84, 22);
            this.txtLamb.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(100, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Obliczanie siły ciągnięcia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(497, 34);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(227, 25);
            this.label9.TabIndex = 19;
            this.label9.Text = "Dobór średnicy ciągadła:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(838, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLamb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDciagadlo);
            this.Controls.Add(this.txtD0ciagadlo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtD1);
            this.Controls.Add(this.txtD0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.btnOblicz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOblicz;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtD0;
        private System.Windows.Forms.TextBox txtD1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtD0ciagadlo;
        private System.Windows.Forms.TextBox txtDciagadlo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLamb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

