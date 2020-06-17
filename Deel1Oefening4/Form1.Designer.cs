namespace Deel1Oefening4
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxVoornaam = new System.Windows.Forms.TextBox();
            this.textBoxAchternaam = new System.Windows.Forms.TextBox();
            this.textBoxResultaat = new System.Windows.Forms.TextBox();
            this.buttonZoek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Voornaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Achternaam";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultaat";
            // 
            // textBoxVoornaam
            // 
            this.textBoxVoornaam.Location = new System.Drawing.Point(101, 63);
            this.textBoxVoornaam.Name = "textBoxVoornaam";
            this.textBoxVoornaam.Size = new System.Drawing.Size(117, 26);
            this.textBoxVoornaam.TabIndex = 3;
            // 
            // textBoxAchternaam
            // 
            this.textBoxAchternaam.Location = new System.Drawing.Point(326, 63);
            this.textBoxAchternaam.Name = "textBoxAchternaam";
            this.textBoxAchternaam.Size = new System.Drawing.Size(147, 26);
            this.textBoxAchternaam.TabIndex = 4;
            // 
            // textBoxResultaat
            // 
            this.textBoxResultaat.Location = new System.Drawing.Point(23, 235);
            this.textBoxResultaat.Multiline = true;
            this.textBoxResultaat.Name = "textBoxResultaat";
            this.textBoxResultaat.ReadOnly = true;
            this.textBoxResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultaat.Size = new System.Drawing.Size(1629, 874);
            this.textBoxResultaat.TabIndex = 5;
            // 
            // buttonZoek
            // 
            this.buttonZoek.Location = new System.Drawing.Point(501, 39);
            this.buttonZoek.Name = "buttonZoek";
            this.buttonZoek.Size = new System.Drawing.Size(166, 74);
            this.buttonZoek.TabIndex = 6;
            this.buttonZoek.Text = "Zoek";
            this.buttonZoek.UseVisualStyleBackColor = true;
            this.buttonZoek.Click += new System.EventHandler(this.buttonZoek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 1121);
            this.Controls.Add(this.buttonZoek);
            this.Controls.Add(this.textBoxResultaat);
            this.Controls.Add(this.textBoxAchternaam);
            this.Controls.Add(this.textBoxVoornaam);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxVoornaam;
        private System.Windows.Forms.TextBox textBoxAchternaam;
        private System.Windows.Forms.TextBox textBoxResultaat;
        private System.Windows.Forms.Button buttonZoek;
    }
}

