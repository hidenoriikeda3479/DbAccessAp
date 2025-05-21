namespace DbAccessAP
{
    partial class EditEmployeeForm
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
            nameTextBox = new TextBox();
            ageTextBox = new TextBox();
            dtEditForm = new ComboBox();
            nameLabel = new Label();
            ageLabel = new Label();
            dtEditLabel = new Label();
            editingButton = new Button();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(84, 33);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(146, 23);
            nameTextBox.TabIndex = 0;
            // 
            // ageTextBox
            // 
            ageTextBox.Location = new Point(84, 74);
            ageTextBox.Name = "ageTextBox";
            ageTextBox.Size = new Size(146, 23);
            ageTextBox.TabIndex = 1;
            // 
            // dtEditForm
            // 
            dtEditForm.FormattingEnabled = true;
            dtEditForm.Location = new Point(84, 114);
            dtEditForm.Name = "dtEditForm";
            dtEditForm.Size = new Size(146, 23);
            dtEditForm.TabIndex = 2;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new Point(23, 36);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(55, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "従業員名";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.Location = new Point(47, 77);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(31, 15);
            ageLabel.TabIndex = 5;
            ageLabel.Text = "年齢";
            // 
            // dtEditLabel
            // 
            dtEditLabel.AutoSize = true;
            dtEditLabel.Location = new Point(47, 117);
            dtEditLabel.Name = "dtEditLabel";
            dtEditLabel.Size = new Size(31, 15);
            dtEditLabel.TabIndex = 6;
            dtEditLabel.Text = "部署";
            // 
            // editingButton
            // 
            editingButton.Location = new Point(157, 176);
            editingButton.Name = "editingButton";
            editingButton.Size = new Size(73, 22);
            editingButton.TabIndex = 7;
            editingButton.Text = "編集";
            editingButton.UseVisualStyleBackColor = true;
            editingButton.Click += button1_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(279, 223);
            Controls.Add(editingButton);
            Controls.Add(dtEditLabel);
            Controls.Add(ageLabel);
            Controls.Add(nameLabel);
            Controls.Add(dtEditForm);
            Controls.Add(ageTextBox);
            Controls.Add(nameTextBox);
            Name = "EditEmployeeForm";
            Text = "従業員情報の変更";
            Load += EditForm1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTextBox;
        private TextBox ageTextBox;
        private ComboBox dtEditForm;
        private Label nameLabel;
        private Label ageLabel;
        private Label dtEditLabel;
        private Button editingButton;
    }
}