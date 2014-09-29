namespace NumberListbox
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
            this.itemnumbertextBox = new System.Windows.Forms.TextBox();
            this.addbutton = new System.Windows.Forms.Button();
            this.numberlistBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Number";
            // 
            // itemnumbertextBox
            // 
            this.itemnumbertextBox.Location = new System.Drawing.Point(206, 33);
            this.itemnumbertextBox.Name = "itemnumbertextBox";
            this.itemnumbertextBox.Size = new System.Drawing.Size(100, 20);
            this.itemnumbertextBox.TabIndex = 1;
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(417, 33);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(75, 23);
            this.addbutton.TabIndex = 2;
            this.addbutton.Text = "Add";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // numberlistBox
            // 
            this.numberlistBox.FormattingEnabled = true;
            this.numberlistBox.Location = new System.Drawing.Point(206, 97);
            this.numberlistBox.Name = "numberlistBox";
            this.numberlistBox.Size = new System.Drawing.Size(120, 95);
            this.numberlistBox.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 294);
            this.Controls.Add(this.numberlistBox);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.itemnumbertextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "List Box";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox itemnumbertextBox;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.ListBox numberlistBox;
    }
}

