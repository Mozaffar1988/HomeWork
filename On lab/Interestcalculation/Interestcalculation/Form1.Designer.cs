namespace Interestcalculation
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
            this.bnankcomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timetextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.balancetextBox = new System.Windows.Forms.TextBox();
            this.calculationButton = new System.Windows.Forms.Button();
            this.interest = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bank Name";
            // 
            // bnankcomboBox
            // 
            this.bnankcomboBox.FormattingEnabled = true;
            this.bnankcomboBox.Items.AddRange(new object[] {
            "BRAC",
            "DBBL",
            "HSBC"});
            this.bnankcomboBox.Location = new System.Drawing.Point(165, 22);
            this.bnankcomboBox.Name = "bnankcomboBox";
            this.bnankcomboBox.Size = new System.Drawing.Size(121, 21);
            this.bnankcomboBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time (in year)";
            // 
            // timetextBox
            // 
            this.timetextBox.Location = new System.Drawing.Point(165, 103);
            this.timetextBox.Name = "timetextBox";
            this.timetextBox.Size = new System.Drawing.Size(100, 20);
            this.timetextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Balance";
            // 
            // balancetextBox
            // 
            this.balancetextBox.Location = new System.Drawing.Point(165, 174);
            this.balancetextBox.Name = "balancetextBox";
            this.balancetextBox.Size = new System.Drawing.Size(100, 20);
            this.balancetextBox.TabIndex = 5;
            this.balancetextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // calculationButton
            // 
            this.calculationButton.Location = new System.Drawing.Point(165, 227);
            this.calculationButton.Name = "calculationButton";
            this.calculationButton.Size = new System.Drawing.Size(139, 23);
            this.calculationButton.TabIndex = 6;
            this.calculationButton.Text = "Calculate Interest";
            this.calculationButton.UseVisualStyleBackColor = true;
            this.calculationButton.Click += new System.EventHandler(this.calculationButton_Click);
            // 
            // interest
            // 
            this.interest.AutoSize = true;
            this.interest.Location = new System.Drawing.Point(162, 283);
            this.interest.Name = "interest";
            this.interest.Size = new System.Drawing.Size(50, 13);
            this.interest.TabIndex = 8;
            this.interest.Text = "interest =";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(230, 283);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 321);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.interest);
            this.Controls.Add(this.calculationButton);
            this.Controls.Add(this.balancetextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timetextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnankcomboBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "InterestCalculationForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bnankcomboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timetextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox balancetextBox;
        private System.Windows.Forms.Button calculationButton;
        private System.Windows.Forms.Label interest;
        private System.Windows.Forms.Label resultLabel;
    }
}

