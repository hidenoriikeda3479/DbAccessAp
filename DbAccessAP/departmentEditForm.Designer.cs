namespace DbAccessAP
{
    partial class editDepartmentForm
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
            editDepartmentTextBox = new TextBox();
            editDepartmentButton = new Button();
            departmentLabel = new Label();
            SuspendLayout();
            // 
            // editDepartmentTextBox
            // 
            editDepartmentTextBox.Location = new Point(81, 71);
            editDepartmentTextBox.Name = "editDepartmentTextBox";
            editDepartmentTextBox.Size = new Size(151, 23);
            editDepartmentTextBox.TabIndex = 0;
            // 
            // editDepartmentButton
            // 
            editDepartmentButton.Location = new Point(238, 70);
            editDepartmentButton.Name = "editDepartmentButton";
            editDepartmentButton.Size = new Size(75, 23);
            editDepartmentButton.TabIndex = 1;
            editDepartmentButton.Text = "編集";
            editDepartmentButton.UseVisualStyleBackColor = true;
            editDepartmentButton.Click += editButton_Click;
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(32, 74);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(43, 15);
            departmentLabel.TabIndex = 2;
            departmentLabel.Text = "部署名";
            // 
            // editDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 160);
            Controls.Add(departmentLabel);
            Controls.Add(editDepartmentButton);
            Controls.Add(editDepartmentTextBox);
            Name = "editDepartmentForm";
            Text = "部署編集";
            Load += departmentEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox editDepartmentTextBox;
        private Button editDepartmentButton;
        private Label departmentLabel;
    }
}