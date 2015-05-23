namespace PersonalInformation
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.fatherLabel = new System.Windows.Forms.Label();
            this.motherLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.fatherTextBox = new System.Windows.Forms.TextBox();
            this.motherTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.allInfoButton = new System.Windows.Forms.Button();
            this.nameButton = new System.Windows.Forms.Button();
            this.parentButton = new System.Windows.Forms.Button();
            this.addressButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(73, 51);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(73, 81);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last Name";
            // 
            // fatherLabel
            // 
            this.fatherLabel.AutoSize = true;
            this.fatherLabel.Location = new System.Drawing.Point(73, 110);
            this.fatherLabel.Name = "fatherLabel";
            this.fatherLabel.Size = new System.Drawing.Size(75, 13);
            this.fatherLabel.TabIndex = 2;
            this.fatherLabel.Text = "Father\'s Name";
            // 
            // motherLabel
            // 
            this.motherLabel.AutoSize = true;
            this.motherLabel.Location = new System.Drawing.Point(73, 135);
            this.motherLabel.Name = "motherLabel";
            this.motherLabel.Size = new System.Drawing.Size(78, 13);
            this.motherLabel.TabIndex = 3;
            this.motherLabel.Text = "Mother\'s Name";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(73, 164);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Address";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(159, 44);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNameTextBox.TabIndex = 5;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(159, 74);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lastNameTextBox.TabIndex = 6;
            // 
            // fatherTextBox
            // 
            this.fatherTextBox.Location = new System.Drawing.Point(159, 102);
            this.fatherTextBox.Name = "fatherTextBox";
            this.fatherTextBox.Size = new System.Drawing.Size(100, 20);
            this.fatherTextBox.TabIndex = 7;
            // 
            // motherTextBox
            // 
            this.motherTextBox.Location = new System.Drawing.Point(159, 128);
            this.motherTextBox.Name = "motherTextBox";
            this.motherTextBox.Size = new System.Drawing.Size(100, 20);
            this.motherTextBox.TabIndex = 8;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(159, 157);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 9;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(59, 218);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // allInfoButton
            // 
            this.allInfoButton.Location = new System.Drawing.Point(140, 218);
            this.allInfoButton.Name = "allInfoButton";
            this.allInfoButton.Size = new System.Drawing.Size(167, 23);
            this.allInfoButton.TabIndex = 11;
            this.allInfoButton.Text = "Show all information";
            this.allInfoButton.UseVisualStyleBackColor = true;
            this.allInfoButton.Click += new System.EventHandler(this.allInfoButton_Click);
            // 
            // nameButton
            // 
            this.nameButton.Location = new System.Drawing.Point(59, 247);
            this.nameButton.Name = "nameButton";
            this.nameButton.Size = new System.Drawing.Size(75, 23);
            this.nameButton.TabIndex = 12;
            this.nameButton.Text = "Name";
            this.nameButton.UseVisualStyleBackColor = true;
            // 
            // parentButton
            // 
            this.parentButton.Location = new System.Drawing.Point(140, 247);
            this.parentButton.Name = "parentButton";
            this.parentButton.Size = new System.Drawing.Size(86, 23);
            this.parentButton.TabIndex = 13;
            this.parentButton.Text = "Parent\'s Name";
            this.parentButton.UseVisualStyleBackColor = true;
            // 
            // addressButton
            // 
            this.addressButton.Location = new System.Drawing.Point(232, 247);
            this.addressButton.Name = "addressButton";
            this.addressButton.Size = new System.Drawing.Size(75, 23);
            this.addressButton.TabIndex = 14;
            this.addressButton.Text = "Address";
            this.addressButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 318);
            this.Controls.Add(this.addressButton);
            this.Controls.Add(this.parentButton);
            this.Controls.Add(this.nameButton);
            this.Controls.Add(this.allInfoButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.motherTextBox);
            this.Controls.Add(this.fatherTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.motherLabel);
            this.Controls.Add(this.fatherLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label fatherLabel;
        private System.Windows.Forms.Label motherLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox fatherTextBox;
        private System.Windows.Forms.TextBox motherTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button allInfoButton;
        private System.Windows.Forms.Button nameButton;
        private System.Windows.Forms.Button parentButton;
        private System.Windows.Forms.Button addressButton;
    }
}

