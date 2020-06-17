namespace Deel3Oefening3
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNumeric = new System.Windows.Forms.TabPage();
            this.tabPageString = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOndergens = new System.Windows.Forms.TextBox();
            this.textBoxBovengrens = new System.Windows.Forms.TextBox();
            this.textBoxResultaat = new System.Windows.Forms.TextBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxScheidingsteken = new System.Windows.Forms.TextBox();
            this.textBoxNamenReeks = new System.Windows.Forms.TextBox();
            this.textBoxResultaatString = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonBegintMet = new System.Windows.Forms.RadioButton();
            this.radioButtonEindigtMet = new System.Windows.Forms.RadioButton();
            this.radioButtonBevat = new System.Windows.Forms.RadioButton();
            this.textBoxZoek = new System.Windows.Forms.TextBox();
            this.buttonGoString = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageNumeric.SuspendLayout();
            this.tabPageString.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNumeric);
            this.tabControl1.Controls.Add(this.tabPageString);
            this.tabControl1.Location = new System.Drawing.Point(12, 21);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1232, 1366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageNumeric
            // 
            this.tabPageNumeric.Controls.Add(this.buttonGo);
            this.tabPageNumeric.Controls.Add(this.textBoxResultaat);
            this.tabPageNumeric.Controls.Add(this.textBoxBovengrens);
            this.tabPageNumeric.Controls.Add(this.textBoxOndergens);
            this.tabPageNumeric.Controls.Add(this.label3);
            this.tabPageNumeric.Controls.Add(this.label2);
            this.tabPageNumeric.Controls.Add(this.label1);
            this.tabPageNumeric.Location = new System.Drawing.Point(4, 29);
            this.tabPageNumeric.Name = "tabPageNumeric";
            this.tabPageNumeric.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNumeric.Size = new System.Drawing.Size(1224, 1333);
            this.tabPageNumeric.TabIndex = 0;
            this.tabPageNumeric.Text = "Numeric-based";
            this.tabPageNumeric.UseVisualStyleBackColor = true;
            // 
            // tabPageString
            // 
            this.tabPageString.Controls.Add(this.label6);
            this.tabPageString.Controls.Add(this.groupBox1);
            this.tabPageString.Controls.Add(this.textBoxResultaatString);
            this.tabPageString.Controls.Add(this.textBoxNamenReeks);
            this.tabPageString.Controls.Add(this.textBoxScheidingsteken);
            this.tabPageString.Controls.Add(this.label5);
            this.tabPageString.Controls.Add(this.label4);
            this.tabPageString.Location = new System.Drawing.Point(4, 29);
            this.tabPageString.Name = "tabPageString";
            this.tabPageString.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageString.Size = new System.Drawing.Size(1224, 1333);
            this.tabPageString.TabIndex = 1;
            this.tabPageString.Text = "String-based";
            this.tabPageString.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ondergrens";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(315, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bovngrens";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Even getallen binnen de opgegeven grenzen";
            // 
            // textBoxOndergens
            // 
            this.textBoxOndergens.Location = new System.Drawing.Point(136, 51);
            this.textBoxOndergens.Name = "textBoxOndergens";
            this.textBoxOndergens.Size = new System.Drawing.Size(100, 26);
            this.textBoxOndergens.TabIndex = 3;
            // 
            // textBoxBovengrens
            // 
            this.textBoxBovengrens.Location = new System.Drawing.Point(431, 54);
            this.textBoxBovengrens.Name = "textBoxBovengrens";
            this.textBoxBovengrens.Size = new System.Drawing.Size(100, 26);
            this.textBoxBovengrens.TabIndex = 4;
            // 
            // textBoxResultaat
            // 
            this.textBoxResultaat.Location = new System.Drawing.Point(41, 241);
            this.textBoxResultaat.Multiline = true;
            this.textBoxResultaat.Name = "textBoxResultaat";
            this.textBoxResultaat.ReadOnly = true;
            this.textBoxResultaat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultaat.Size = new System.Drawing.Size(632, 1052);
            this.textBoxResultaat.TabIndex = 5;
            // 
            // buttonGo
            // 
            this.buttonGo.Location = new System.Drawing.Point(573, 51);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(100, 40);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go!...";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Scheidingsteken";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Namen reeks";
            // 
            // textBoxScheidingsteken
            // 
            this.textBoxScheidingsteken.Location = new System.Drawing.Point(158, 32);
            this.textBoxScheidingsteken.Name = "textBoxScheidingsteken";
            this.textBoxScheidingsteken.Size = new System.Drawing.Size(100, 26);
            this.textBoxScheidingsteken.TabIndex = 2;
            // 
            // textBoxNamenReeks
            // 
            this.textBoxNamenReeks.Location = new System.Drawing.Point(158, 105);
            this.textBoxNamenReeks.Name = "textBoxNamenReeks";
            this.textBoxNamenReeks.Size = new System.Drawing.Size(1015, 26);
            this.textBoxNamenReeks.TabIndex = 3;
            // 
            // textBoxResultaatString
            // 
            this.textBoxResultaatString.Location = new System.Drawing.Point(35, 600);
            this.textBoxResultaatString.Multiline = true;
            this.textBoxResultaatString.Name = "textBoxResultaatString";
            this.textBoxResultaatString.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResultaatString.Size = new System.Drawing.Size(1166, 715);
            this.textBoxResultaatString.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonGoString);
            this.groupBox1.Controls.Add(this.textBoxZoek);
            this.groupBox1.Controls.Add(this.radioButtonBevat);
            this.groupBox1.Controls.Add(this.radioButtonEindigtMet);
            this.groupBox1.Controls.Add(this.radioButtonBegintMet);
            this.groupBox1.Location = new System.Drawing.Point(29, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1172, 348);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filter criteria";
            // 
            // radioButtonBegintMet
            // 
            this.radioButtonBegintMet.AutoSize = true;
            this.radioButtonBegintMet.Checked = true;
            this.radioButtonBegintMet.Location = new System.Drawing.Point(6, 45);
            this.radioButtonBegintMet.Name = "radioButtonBegintMet";
            this.radioButtonBegintMet.Size = new System.Drawing.Size(111, 24);
            this.radioButtonBegintMet.TabIndex = 0;
            this.radioButtonBegintMet.TabStop = true;
            this.radioButtonBegintMet.Text = "Begint met";
            this.radioButtonBegintMet.UseVisualStyleBackColor = true;
            // 
            // radioButtonEindigtMet
            // 
            this.radioButtonEindigtMet.AutoSize = true;
            this.radioButtonEindigtMet.Location = new System.Drawing.Point(196, 45);
            this.radioButtonEindigtMet.Name = "radioButtonEindigtMet";
            this.radioButtonEindigtMet.Size = new System.Drawing.Size(114, 24);
            this.radioButtonEindigtMet.TabIndex = 1;
            this.radioButtonEindigtMet.TabStop = true;
            this.radioButtonEindigtMet.Text = "Eindigt met";
            this.radioButtonEindigtMet.UseVisualStyleBackColor = true;
            // 
            // radioButtonBevat
            // 
            this.radioButtonBevat.AutoSize = true;
            this.radioButtonBevat.Location = new System.Drawing.Point(405, 45);
            this.radioButtonBevat.Name = "radioButtonBevat";
            this.radioButtonBevat.Size = new System.Drawing.Size(75, 24);
            this.radioButtonBevat.TabIndex = 2;
            this.radioButtonBevat.TabStop = true;
            this.radioButtonBevat.Text = "Bevat";
            this.radioButtonBevat.UseVisualStyleBackColor = true;
            // 
            // textBoxZoek
            // 
            this.textBoxZoek.Location = new System.Drawing.Point(7, 105);
            this.textBoxZoek.Name = "textBoxZoek";
            this.textBoxZoek.Size = new System.Drawing.Size(1137, 26);
            this.textBoxZoek.TabIndex = 3;
            // 
            // buttonGoString
            // 
            this.buttonGoString.Location = new System.Drawing.Point(866, 181);
            this.buttonGoString.Name = "buttonGoString";
            this.buttonGoString.Size = new System.Drawing.Size(278, 108);
            this.buttonGoString.TabIndex = 4;
            this.buttonGoString.Text = "Go!...";
            this.buttonGoString.UseVisualStyleBackColor = true;
            this.buttonGoString.Click += new System.EventHandler(this.buttonGoString_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 565);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Resultaat:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 1420);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPageNumeric.ResumeLayout(false);
            this.tabPageNumeric.PerformLayout();
            this.tabPageString.ResumeLayout(false);
            this.tabPageString.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNumeric;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TextBox textBoxResultaat;
        private System.Windows.Forms.TextBox textBoxBovengrens;
        private System.Windows.Forms.TextBox textBoxOndergens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageString;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonGoString;
        private System.Windows.Forms.TextBox textBoxZoek;
        private System.Windows.Forms.RadioButton radioButtonBevat;
        private System.Windows.Forms.RadioButton radioButtonEindigtMet;
        private System.Windows.Forms.RadioButton radioButtonBegintMet;
        private System.Windows.Forms.TextBox textBoxResultaatString;
        private System.Windows.Forms.TextBox textBoxNamenReeks;
        private System.Windows.Forms.TextBox textBoxScheidingsteken;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

