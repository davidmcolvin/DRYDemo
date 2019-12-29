namespace WinFormUI
{
  partial class Dashboard
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
      this.headerMain = new System.Windows.Forms.Label();
      this.headerFirstNameLabel = new System.Windows.Forms.Label();
      this.firstNameTextBox = new System.Windows.Forms.TextBox();
      this.lastNameTextBox = new System.Windows.Forms.TextBox();
      this.headerLastNameLabel = new System.Windows.Forms.Label();
      this.generateButton = new System.Windows.Forms.Button();
      this.employeeIdTextBox = new System.Windows.Forms.TextBox();
      this.headerEmployeeIdLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // headerMain
      // 
      this.headerMain.AutoSize = true;
      this.headerMain.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.headerMain.Location = new System.Drawing.Point(80, 37);
      this.headerMain.Name = "headerMain";
      this.headerMain.Size = new System.Drawing.Size(344, 37);
      this.headerMain.TabIndex = 0;
      this.headerMain.Text = "Employee Creation Demo";
      // 
      // headerFirstNameLabel
      // 
      this.headerFirstNameLabel.AutoSize = true;
      this.headerFirstNameLabel.Location = new System.Drawing.Point(72, 125);
      this.headerFirstNameLabel.Name = "headerFirstNameLabel";
      this.headerFirstNameLabel.Size = new System.Drawing.Size(106, 25);
      this.headerFirstNameLabel.TabIndex = 0;
      this.headerFirstNameLabel.Text = "First Name:";
      // 
      // firstNameTextBox
      // 
      this.firstNameTextBox.Location = new System.Drawing.Point(184, 122);
      this.firstNameTextBox.Name = "firstNameTextBox";
      this.firstNameTextBox.Size = new System.Drawing.Size(248, 33);
      this.firstNameTextBox.TabIndex = 1;
      // 
      // lastNameTextBox
      // 
      this.lastNameTextBox.Location = new System.Drawing.Point(184, 183);
      this.lastNameTextBox.Name = "lastNameTextBox";
      this.lastNameTextBox.Size = new System.Drawing.Size(248, 33);
      this.lastNameTextBox.TabIndex = 2;
      // 
      // headerLastNameLabel
      // 
      this.headerLastNameLabel.AutoSize = true;
      this.headerLastNameLabel.Location = new System.Drawing.Point(74, 186);
      this.headerLastNameLabel.Name = "headerLastNameLabel";
      this.headerLastNameLabel.Size = new System.Drawing.Size(104, 25);
      this.headerLastNameLabel.TabIndex = 0;
      this.headerLastNameLabel.Text = "Last Name:";
      // 
      // generateButton
      // 
      this.generateButton.Location = new System.Drawing.Point(147, 262);
      this.generateButton.Name = "generateButton";
      this.generateButton.Size = new System.Drawing.Size(211, 77);
      this.generateButton.TabIndex = 3;
      this.generateButton.Text = "Generate Employee ID";
      this.generateButton.UseVisualStyleBackColor = true;
      this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
      // 
      // employeeIdTextBox
      // 
      this.employeeIdTextBox.Location = new System.Drawing.Point(184, 377);
      this.employeeIdTextBox.Name = "employeeIdTextBox";
      this.employeeIdTextBox.Size = new System.Drawing.Size(248, 33);
      this.employeeIdTextBox.TabIndex = 4;
      // 
      // headerEmployeeIdLabel
      // 
      this.headerEmployeeIdLabel.AutoSize = true;
      this.headerEmployeeIdLabel.Location = new System.Drawing.Point(57, 380);
      this.headerEmployeeIdLabel.Name = "headerEmployeeIdLabel";
      this.headerEmployeeIdLabel.Size = new System.Drawing.Size(121, 25);
      this.headerEmployeeIdLabel.TabIndex = 0;
      this.headerEmployeeIdLabel.Text = "Employee ID:";
      // 
      // Dashboard
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(504, 490);
      this.Controls.Add(this.employeeIdTextBox);
      this.Controls.Add(this.headerEmployeeIdLabel);
      this.Controls.Add(this.generateButton);
      this.Controls.Add(this.lastNameTextBox);
      this.Controls.Add(this.headerLastNameLabel);
      this.Controls.Add(this.firstNameTextBox);
      this.Controls.Add(this.headerFirstNameLabel);
      this.Controls.Add(this.headerMain);
      this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
      this.Name = "Dashboard";
      this.Text = "DRY Demo";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Label headerMain;
        private System.Windows.Forms.Label headerFirstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label headerLastNameLabel;
        private System.Windows.Forms.Button generateButton;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.Label headerEmployeeIdLabel;
    }
}

