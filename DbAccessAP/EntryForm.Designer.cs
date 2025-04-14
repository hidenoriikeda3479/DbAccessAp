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
            entryButton1 = new Button();
            employeeNameInput = new TextBox();
            ageInput = new TextBox();
            departmentNameInput = new TextBox();
            employeeNameLabel = new Label();
            ageLabel = new Label();
            departmentNameLabel = new Label();
            SuspendLayout();
            // 
            // entryButton1
            // 
            entryButton1.Location = new Point(676, 28);
            entryButton1.Name = "entryButton1";
            entryButton1.Size = new Size(65, 33);
            entryButton1.TabIndex = 0;
            entryButton1.Text = "登録";
            entryButton1.UseVisualStyleBackColor = true;
            entryButton1.Click += entryButton1_Click;
            // 
            // employeeNameInput
            // 
            employeeNameInput.Location = new Point(114, 34);
            employeeNameInput.Name = "employeeNameInput";
            employeeNameInput.Size = new Size(117, 23);
            employeeNameInput.TabIndex = 1;
            // 
            // ageInput
            // 
            ageInput.Location = new Point(309, 34);
            ageInput.Name = "ageInput";
            ageInput.Size = new Size(117, 23);
            ageInput.TabIndex = 2;
            // 
            // departmentNameInput
            // 
            departmentNameInput.Location = new Point(507, 34);
            departmentNameInput.Name = "departmentNameInput";
            departmentNameInput.Size = new Size(117, 23);
            departmentNameInput.TabIndex = 3;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(53, 37);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(55, 15);
            employeeNameLabel.TabIndex = 4;
            employeeNameLabel.Text = "従業員名";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(272, 37);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(31, 15);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "年齢";
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.ImageAlign = ContentAlignment.TopLeft;
            departmentNameLabel.Location = new Point(458, 37);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new Size(43, 15);
            departmentNameLabel.TabIndex = 6;
            departmentNameLabel.Text = "部署名";
            // 
            // EntryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(departmentNameLabel);
            Controls.Add(ageLabel);
            Controls.Add(employeeNameLabel);
            Controls.Add(departmentNameInput);
            Controls.Add(ageInput);
            Controls.Add(employeeNameInput);
            Controls.Add(entryButton1);
            Name = "EntryForm";
            Text = "EntryForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button entryButton1;
        private TextBox employeeNameInput;
        private TextBox ageInput;
        private TextBox departmentNameInput;
        private Label employeeNameLabel;
        private Label ageLabel;
        protected internal Label departmentNameLabel;
        private Label ageLabel3;
    }
}