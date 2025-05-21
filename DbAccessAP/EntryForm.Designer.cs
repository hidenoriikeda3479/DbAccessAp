namespace DbAccessAP
{
    partial class EntryForm
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
            entryButton = new Button();
            nameTextBox = new TextBox();
            ageInputTextBox = new TextBox();
            employeeNameLabel = new Label();
            ageLabel = new Label();
            departmentIdLabel = new Label();
            departmentComboBox = new ComboBox();
            clearButton = new Button();
            SuspendLayout();
            // 
            // entryButton
            // 
            entryButton.Location = new Point(179, 190);
            entryButton.Name = "entryButton";
            entryButton.Size = new Size(65, 22);
            entryButton.TabIndex = 0;
            entryButton.Text = "登録";
            entryButton.UseVisualStyleBackColor = true;
            entryButton.Click += entryButton1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(73, 38);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(171, 23);
            nameTextBox.TabIndex = 1;
            // 
            // ageInputTextBox
            // 
            ageInputTextBox.Location = new Point(73, 87);
            ageInputTextBox.Name = "ageInputTextBox";
            ageInputTextBox.Size = new Size(171, 23);
            ageInputTextBox.TabIndex = 2;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(12, 41);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(55, 15);
            employeeNameLabel.TabIndex = 4;
            employeeNameLabel.Text = "従業員名";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(36, 95);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(31, 15);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "年齢";
            // 
            // departmentIdLabel
            // 
            departmentIdLabel.AutoSize = true;
            departmentIdLabel.ImageAlign = ContentAlignment.TopLeft;
            departmentIdLabel.Location = new Point(24, 145);
            departmentIdLabel.Name = "departmentIdLabel";
            departmentIdLabel.Size = new Size(43, 15);
            departmentIdLabel.TabIndex = 8;
            departmentIdLabel.Text = "部署名";
            // 
            // departmentComboBox
            // 
            departmentComboBox.FormattingEnabled = true;
            departmentComboBox.Location = new Point(73, 142);
            departmentComboBox.Name = "departmentComboBox";
            departmentComboBox.Size = new Size(171, 23);
            departmentComboBox.TabIndex = 9;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(108, 190);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(65, 22);
            clearButton.TabIndex = 10;
            clearButton.Text = "クリア";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += button1_Click;
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 240);
            Controls.Add(clearButton);
            Controls.Add(departmentComboBox);
            Controls.Add(departmentIdLabel);
            Controls.Add(ageLabel);
            Controls.Add(employeeNameLabel);
            Controls.Add(ageInputTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(entryButton);
            Name = "EntryForm";
            ShowInTaskbar = false;
            Text = "従業員登録";
            Load += EntryForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button entryButton;
        private TextBox nameTextBox;
        private TextBox ageInputTextBox;
        private Label employeeNameLabel;
        private Label ageLabel;
        private Label ageLabel3;
        protected internal Label departmentIdLabel;
        private ComboBox departmentComboBox;
        private Button clearButton;
    }
}