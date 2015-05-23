namespace InterestCalculator
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
            this.amountLabel = new System.Windows.Forms.Label();
            this.interestLabel = new System.Windows.Forms.Label();
            this.compoundLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.interestTextBox = new System.Windows.Forms.TextBox();
            this.compoundTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.calButton = new System.Windows.Forms.Button();
            this.modLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(72, 35);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(86, 13);
            this.amountLabel.TabIndex = 0;
            this.amountLabel.Text = "Principal Amount";
            // 
            // interestLabel
            // 
            this.interestLabel.AutoSize = true;
            this.interestLabel.Location = new System.Drawing.Point(72, 74);
            this.interestLabel.Name = "interestLabel";
            this.interestLabel.Size = new System.Drawing.Size(68, 13);
            this.interestLabel.TabIndex = 1;
            this.interestLabel.Text = "Interest Rate";
            // 
            // compoundLabel
            // 
            this.compoundLabel.AutoSize = true;
            this.compoundLabel.Location = new System.Drawing.Point(72, 108);
            this.compoundLabel.Name = "compoundLabel";
            this.compoundLabel.Size = new System.Drawing.Size(96, 13);
            this.compoundLabel.TabIndex = 2;
            this.compoundLabel.Text = "Compound Interest";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(72, 141);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(72, 13);
            this.yearLabel.TabIndex = 3;
            this.yearLabel.Text = "Years to grow";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Location = new System.Drawing.Point(72, 171);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(103, 13);
            this.totalLabel.TabIndex = 4;
            this.totalLabel.Text = "Future Total Amount";
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(177, 32);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 5;
            // 
            // interestTextBox
            // 
            this.interestTextBox.Location = new System.Drawing.Point(177, 66);
            this.interestTextBox.Name = "interestTextBox";
            this.interestTextBox.Size = new System.Drawing.Size(100, 20);
            this.interestTextBox.TabIndex = 6;
            // 
            // compoundTextBox
            // 
            this.compoundTextBox.Location = new System.Drawing.Point(177, 101);
            this.compoundTextBox.Name = "compoundTextBox";
            this.compoundTextBox.Size = new System.Drawing.Size(100, 20);
            this.compoundTextBox.TabIndex = 7;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(177, 133);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(100, 20);
            this.yearTextBox.TabIndex = 8;
            // 
            // totalTextBox
            // 
            this.totalTextBox.Location = new System.Drawing.Point(177, 164);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.totalTextBox.TabIndex = 9;
            // 
            // calButton
            // 
            this.calButton.Location = new System.Drawing.Point(315, 130);
            this.calButton.Name = "calButton";
            this.calButton.Size = new System.Drawing.Size(75, 23);
            this.calButton.TabIndex = 10;
            this.calButton.Text = "Calculate";
            this.calButton.UseVisualStyleBackColor = true;
            this.calButton.Click += new System.EventHandler(this.calButton_Click);
            // 
            // modLabel
            // 
            this.modLabel.AutoSize = true;
            this.modLabel.Location = new System.Drawing.Point(312, 72);
            this.modLabel.Name = "modLabel";
            this.modLabel.Size = new System.Drawing.Size(15, 13);
            this.modLabel.TabIndex = 11;
            this.modLabel.Text = "%";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(315, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "time(s) annually";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 286);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.modLabel);
            this.Controls.Add(this.calButton);
            this.Controls.Add(this.totalTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.compoundTextBox);
            this.Controls.Add(this.interestTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.compoundLabel);
            this.Controls.Add(this.interestLabel);
            this.Controls.Add(this.amountLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label interestLabel;
        private System.Windows.Forms.Label compoundLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox interestTextBox;
        private System.Windows.Forms.TextBox compoundTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.Button calButton;
        private System.Windows.Forms.Label modLabel;
        private System.Windows.Forms.Label label7;
    }
}

