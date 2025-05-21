namespace DbAccessAP
{
    partial class AddDepartmentRegisterForm
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
            addDepartmentTextBox = new TextBox();
            addDepartmentButton = new Button();
            departmentRegistrationLabel = new Label();
            SuspendLayout();
            // 
            // addDepartmentTextBox
            // 
            addDepartmentTextBox.Location = new Point(71, 56);
            addDepartmentTextBox.Name = "addDepartmentTextBox";
            addDepartmentTextBox.Size = new Size(159, 23);
            addDepartmentTextBox.TabIndex = 0;
            // 
            // addDepartmentButton
            // 
            addDepartmentButton.Location = new Point(236, 56);
            addDepartmentButton.Name = "addDepartmentButton";
            addDepartmentButton.Size = new Size(75, 23);
            addDepartmentButton.TabIndex = 1;
            addDepartmentButton.Text = "登録";
            addDepartmentButton.UseVisualStyleBackColor = true;
            addDepartmentButton.Click += epartmentRegistrationButton_Click;
            // 
            // departmentRegistrationLabel
            // 
            departmentRegistrationLabel.AutoSize = true;
            departmentRegistrationLabel.Location = new Point(22, 60);
            departmentRegistrationLabel.Name = "departmentRegistrationLabel";
            departmentRegistrationLabel.Size = new Size(43, 15);
            departmentRegistrationLabel.TabIndex = 2;
            departmentRegistrationLabel.Text = "部署名";
            // 
            // AddDepartmentRegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(338, 146);
            Controls.Add(departmentRegistrationLabel);
            Controls.Add(addDepartmentButton);
            Controls.Add(addDepartmentTextBox);
            Name = "AddDepartmentRegisterForm";
            Text = "部署登録";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox addDepartmentTextBox;
        private Button addDepartmentButton;
        private Label departmentRegistrationLabel;
    }
}