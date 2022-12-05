namespace Calculator
{
    partial class FrmCalculator
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
            this.OperatorTxt = new System.Windows.Forms.ComboBox();
            this.txtAngka1 = new System.Windows.Forms.TextBox();
            this.txtAngka2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OperatorTxt
            // 
            this.OperatorTxt.FormattingEnabled = true;
            this.OperatorTxt.Items.AddRange(new object[] {
            "Penambahan",
            "Pengurangan",
            "Perkalian",
            "Pembagian"});
            this.OperatorTxt.Location = new System.Drawing.Point(88, 21);
            this.OperatorTxt.Name = "OperatorTxt";
            this.OperatorTxt.Size = new System.Drawing.Size(105, 21);
            this.OperatorTxt.TabIndex = 0;
            // 
            // txtAngka1
            // 
            this.txtAngka1.Location = new System.Drawing.Point(88, 59);
            this.txtAngka1.Name = "txtAngka1";
            this.txtAngka1.Size = new System.Drawing.Size(105, 20);
            this.txtAngka1.TabIndex = 1;
            // 
            // txtAngka2
            // 
            this.txtAngka2.Location = new System.Drawing.Point(88, 99);
            this.txtAngka2.Name = "txtAngka2";
            this.txtAngka2.Size = new System.Drawing.Size(105, 20);
            this.txtAngka2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 150);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Hitung";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Operator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Angka1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Angka2";
            // 
            // FrmCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 222);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAngka2);
            this.Controls.Add(this.txtAngka1);
            this.Controls.Add(this.OperatorTxt);
            this.Name = "FrmCalculator";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox OperatorTxt;
        private System.Windows.Forms.TextBox txtAngka1;
        private System.Windows.Forms.TextBox txtAngka2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}