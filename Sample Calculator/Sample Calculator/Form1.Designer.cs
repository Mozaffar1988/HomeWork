namespace Sample_Calculator
{
    partial class simplecalculatorFormUI
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
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplayButton = new System.Windows.Forms.Button();
            this.divideButton = new System.Windows.Forms.Button();
            this.firstnumbertextBox = new System.Windows.Forms.TextBox();
            this.secondnumbertextBox = new System.Windows.Forms.TextBox();
            this.resulttextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Result";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(107, 210);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(210, 210);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // multiplayButton
            // 
            this.multiplayButton.Location = new System.Drawing.Point(315, 210);
            this.multiplayButton.Name = "multiplayButton";
            this.multiplayButton.Size = new System.Drawing.Size(75, 23);
            this.multiplayButton.TabIndex = 5;
            this.multiplayButton.Text = "Multiplay";
            this.multiplayButton.UseVisualStyleBackColor = true;
            this.multiplayButton.Click += new System.EventHandler(this.multiplayButton_Click);
            // 
            // divideButton
            // 
            this.divideButton.Location = new System.Drawing.Point(415, 210);
            this.divideButton.Name = "divideButton";
            this.divideButton.Size = new System.Drawing.Size(75, 23);
            this.divideButton.TabIndex = 6;
            this.divideButton.Text = "Divide";
            this.divideButton.UseVisualStyleBackColor = true;
            this.divideButton.Click += new System.EventHandler(this.divideButton_Click);
            // 
            // firstnumbertextBox
            // 
            this.firstnumbertextBox.Location = new System.Drawing.Point(185, 63);
            this.firstnumbertextBox.Name = "firstnumbertextBox";
            this.firstnumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.firstnumbertextBox.TabIndex = 7;
            // 
            // secondnumbertextBox
            // 
            this.secondnumbertextBox.Location = new System.Drawing.Point(185, 98);
            this.secondnumbertextBox.Name = "secondnumbertextBox";
            this.secondnumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.secondnumbertextBox.TabIndex = 8;
            // 
            // resulttextBox
            // 
            this.resulttextBox.Location = new System.Drawing.Point(185, 139);
            this.resulttextBox.Name = "resulttextBox";
            this.resulttextBox.Size = new System.Drawing.Size(100, 20);
            this.resulttextBox.TabIndex = 9;
            // 
            // simplecalculatorFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 305);
            this.Controls.Add(this.resulttextBox);
            this.Controls.Add(this.secondnumbertextBox);
            this.Controls.Add(this.firstnumbertextBox);
            this.Controls.Add(this.divideButton);
            this.Controls.Add(this.multiplayButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "simplecalculatorFormUI";
            this.Text = "Simple Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button multiplayButton;
        private System.Windows.Forms.Button divideButton;
        private System.Windows.Forms.TextBox firstnumbertextBox;
        private System.Windows.Forms.TextBox secondnumbertextBox;
        private System.Windows.Forms.TextBox resulttextBox;
    }
}

