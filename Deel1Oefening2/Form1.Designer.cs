namespace Deel1Oefening2
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
            this.textBoxResultaat = new System.Windows.Forms.TextBox();
            this.buttonHaalOp = new System.Windows.Forms.Button();
            this.buttonEersteHonderd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resultaat";
            // 
            // textBoxResultaat
            // 
            this.textBoxResultaat.Location = new System.Drawing.Point(12, 164);
            this.textBoxResultaat.Multiline = true;
            this.textBoxResultaat.Name = "textBoxResultaat";
            this.textBoxResultaat.ReadOnly = true;
            this.textBoxResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultaat.Size = new System.Drawing.Size(1697, 881);
            this.textBoxResultaat.TabIndex = 1;
            // 
            // buttonHaalOp
            // 
            this.buttonHaalOp.Location = new System.Drawing.Point(16, 65);
            this.buttonHaalOp.Name = "buttonHaalOp";
            this.buttonHaalOp.Size = new System.Drawing.Size(161, 45);
            this.buttonHaalOp.TabIndex = 2;
            this.buttonHaalOp.Text = "Tel personen";
            this.buttonHaalOp.UseVisualStyleBackColor = true;
            this.buttonHaalOp.Click += new System.EventHandler(this.buttonHaalOp_Click);
            // 
            // buttonEersteHonderd
            // 
            this.buttonEersteHonderd.Location = new System.Drawing.Point(261, 65);
            this.buttonEersteHonderd.Name = "buttonEersteHonderd";
            this.buttonEersteHonderd.Size = new System.Drawing.Size(152, 45);
            this.buttonEersteHonderd.TabIndex = 3;
            this.buttonEersteHonderd.Text = "Haal eerste 100 op";
            this.buttonEersteHonderd.UseVisualStyleBackColor = true;
            this.buttonEersteHonderd.Click += new System.EventHandler(this.buttonEersteHonderd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1721, 1057);
            this.Controls.Add(this.buttonEersteHonderd);
            this.Controls.Add(this.buttonHaalOp);
            this.Controls.Add(this.textBoxResultaat);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxResultaat;
        private System.Windows.Forms.Button buttonHaalOp;
        private System.Windows.Forms.Button buttonEersteHonderd;
    }
}

