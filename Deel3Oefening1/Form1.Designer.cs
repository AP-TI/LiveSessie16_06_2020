namespace Deel3Oefening1
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
            this.labelValid = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonValideer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelValid
            // 
            this.labelValid.AutoSize = true;
            this.labelValid.Location = new System.Drawing.Point(606, 150);
            this.labelValid.Name = "labelValid";
            this.labelValid.Size = new System.Drawing.Size(0, 20);
            this.labelValid.TabIndex = 0;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(84, 147);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(319, 26);
            this.textBoxInput.TabIndex = 1;
            // 
            // buttonValideer
            // 
            this.buttonValideer.Location = new System.Drawing.Point(436, 139);
            this.buttonValideer.Name = "buttonValideer";
            this.buttonValideer.Size = new System.Drawing.Size(143, 42);
            this.buttonValideer.TabIndex = 2;
            this.buttonValideer.Text = "Valideer";
            this.buttonValideer.UseVisualStyleBackColor = true;
            this.buttonValideer.Click += new System.EventHandler(this.buttonValideer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1961, 1133);
            this.Controls.Add(this.buttonValideer);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.labelValid);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelValid;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonValideer;
    }
}

