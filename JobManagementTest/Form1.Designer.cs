namespace JobManagementTest
{
    partial class JobManagementForm
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
            this.JobsComboBox = new System.Windows.Forms.ComboBox();
            this.Title = new System.Windows.Forms.Label();
            this.JobLabel = new System.Windows.Forms.Label();
            this.ListLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.StartDateTextBox = new System.Windows.Forms.TextBox();
            this.EndDateTextBox = new System.Windows.Forms.TextBox();
            this.EmployeesListBox = new System.Windows.Forms.ListBox();
            this.EMployeeIDLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.JobsLabel = new System.Windows.Forms.Label();
            this.EmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeNameTextBox = new System.Windows.Forms.TextBox();
            this.JobsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // JobsComboBox
            // 
            this.JobsComboBox.FormattingEnabled = true;
            this.JobsComboBox.Location = new System.Drawing.Point(49, 69);
            this.JobsComboBox.Name = "JobsComboBox";
            this.JobsComboBox.Size = new System.Drawing.Size(200, 21);
            this.JobsComboBox.TabIndex = 0;
            this.JobsComboBox.SelectedValueChanged += new System.EventHandler(this.JobsComboBox_SelectedValueChanged);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(12, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(237, 42);
            this.Title.TabIndex = 1;
            this.Title.Text = "Job Manager";
            // 
            // JobLabel
            // 
            this.JobLabel.AutoSize = true;
            this.JobLabel.Location = new System.Drawing.Point(16, 72);
            this.JobLabel.Name = "JobLabel";
            this.JobLabel.Size = new System.Drawing.Size(27, 13);
            this.JobLabel.TabIndex = 2;
            this.JobLabel.Text = "Job:";
            // 
            // ListLabel
            // 
            this.ListLabel.AutoSize = true;
            this.ListLabel.Location = new System.Drawing.Point(9, 132);
            this.ListLabel.Name = "ListLabel";
            this.ListLabel.Size = new System.Drawing.Size(96, 13);
            this.ListLabel.TabIndex = 4;
            this.ListLabel.Text = "Employees on Job:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(338, 26);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(27, 24);
            this.IDLabel.TabIndex = 5;
            this.IDLabel.Text = "ID";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.Location = new System.Drawing.Point(338, 52);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(45, 24);
            this.TitleLabel.TabIndex = 6;
            this.TitleLabel.Text = "Title";
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartDateLabel.Location = new System.Drawing.Point(338, 78);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(89, 24);
            this.StartDateLabel.TabIndex = 7;
            this.StartDateLabel.Text = "Start Date";
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndDateLabel.Location = new System.Drawing.Point(338, 104);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(88, 24);
            this.EndDateLabel.TabIndex = 8;
            this.EndDateLabel.Text = "End Date";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(471, 31);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(186, 20);
            this.IDTextBox.TabIndex = 9;
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(471, 57);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(186, 20);
            this.TitleTextBox.TabIndex = 9;
            // 
            // StartDateTextBox
            // 
            this.StartDateTextBox.Location = new System.Drawing.Point(471, 83);
            this.StartDateTextBox.Name = "StartDateTextBox";
            this.StartDateTextBox.Size = new System.Drawing.Size(186, 20);
            this.StartDateTextBox.TabIndex = 9;
            // 
            // EndDateTextBox
            // 
            this.EndDateTextBox.Location = new System.Drawing.Point(471, 109);
            this.EndDateTextBox.Name = "EndDateTextBox";
            this.EndDateTextBox.Size = new System.Drawing.Size(186, 20);
            this.EndDateTextBox.TabIndex = 9;
            // 
            // EmployeesListBox
            // 
            this.EmployeesListBox.FormattingEnabled = true;
            this.EmployeesListBox.Location = new System.Drawing.Point(12, 148);
            this.EmployeesListBox.Name = "EmployeesListBox";
            this.EmployeesListBox.Size = new System.Drawing.Size(237, 290);
            this.EmployeesListBox.TabIndex = 10;
            // 
            // EMployeeIDLabel
            // 
            this.EMployeeIDLabel.AutoSize = true;
            this.EMployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMployeeIDLabel.Location = new System.Drawing.Point(309, 159);
            this.EMployeeIDLabel.Name = "EMployeeIDLabel";
            this.EMployeeIDLabel.Size = new System.Drawing.Size(118, 24);
            this.EMployeeIDLabel.TabIndex = 11;
            this.EMployeeIDLabel.Text = "Employee ID";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(309, 201);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(152, 24);
            this.EmployeeNameLabel.TabIndex = 11;
            this.EmployeeNameLabel.Text = "Employee Name";
            // 
            // JobsLabel
            // 
            this.JobsLabel.AutoSize = true;
            this.JobsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobsLabel.Location = new System.Drawing.Point(309, 242);
            this.JobsLabel.Name = "JobsLabel";
            this.JobsLabel.Size = new System.Drawing.Size(55, 24);
            this.JobsLabel.TabIndex = 11;
            this.JobsLabel.Text = "Jobs:";
            // 
            // EmployeeIDTextBox
            // 
            this.EmployeeIDTextBox.Location = new System.Drawing.Point(471, 164);
            this.EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            this.EmployeeIDTextBox.Size = new System.Drawing.Size(186, 20);
            this.EmployeeIDTextBox.TabIndex = 9;
            // 
            // EmployeeNameTextBox
            // 
            this.EmployeeNameTextBox.Location = new System.Drawing.Point(471, 206);
            this.EmployeeNameTextBox.Name = "EmployeeNameTextBox";
            this.EmployeeNameTextBox.Size = new System.Drawing.Size(186, 20);
            this.EmployeeNameTextBox.TabIndex = 9;
            // 
            // JobsListBox
            // 
            this.JobsListBox.FormattingEnabled = true;
            this.JobsListBox.Location = new System.Drawing.Point(471, 242);
            this.JobsListBox.Name = "JobsListBox";
            this.JobsListBox.Size = new System.Drawing.Size(186, 186);
            this.JobsListBox.TabIndex = 10;
            // 
            // JobManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.JobsLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Controls.Add(this.EMployeeIDLabel);
            this.Controls.Add(this.JobsListBox);
            this.Controls.Add(this.EmployeesListBox);
            this.Controls.Add(this.EmployeeNameTextBox);
            this.Controls.Add(this.EmployeeIDTextBox);
            this.Controls.Add(this.EndDateTextBox);
            this.Controls.Add(this.StartDateTextBox);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.IDTextBox);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.ListLabel);
            this.Controls.Add(this.JobLabel);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.JobsComboBox);
            this.Name = "JobManagementForm";
            this.Text = "Job Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox JobsComboBox;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label JobLabel;
        private System.Windows.Forms.Label ListLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.TextBox StartDateTextBox;
        private System.Windows.Forms.TextBox EndDateTextBox;
        private System.Windows.Forms.ListBox EmployeesListBox;
        private System.Windows.Forms.Label EMployeeIDLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label JobsLabel;
        private System.Windows.Forms.TextBox EmployeeIDTextBox;
        private System.Windows.Forms.TextBox EmployeeNameTextBox;
        private System.Windows.Forms.ListBox JobsListBox;
    }
}

