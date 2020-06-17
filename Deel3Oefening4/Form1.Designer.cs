namespace Deel3Oefening4
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aantal boetes per speler";
            // 
            // textBoxResultaat
            // 
            this.textBoxResultaat.Location = new System.Drawing.Point(17, 124);
            this.textBoxResultaat.Multiline = true;
            this.textBoxResultaat.Name = "textBoxResultaat";
            this.textBoxResultaat.ReadOnly = true;
            this.textBoxResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultaat.Size = new System.Drawing.Size(1129, 1098);
            this.textBoxResultaat.TabIndex = 1;
            // 
            // buttonHaalOp
            // 
            this.buttonHaalOp.Location = new System.Drawing.Point(216, 20);
            this.buttonHaalOp.Name = "buttonHaalOp";
            this.buttonHaalOp.Size = new System.Drawing.Size(261, 39);
            this.buttonHaalOp.TabIndex = 2;
            this.buttonHaalOp.Text = "Haal boetes op";
            this.buttonHaalOp.UseVisualStyleBackColor = true;
            this.buttonHaalOp.Click += new System.EventHandler(this.buttonHaalOp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 1234);
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
    }
}

