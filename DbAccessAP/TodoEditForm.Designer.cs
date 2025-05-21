namespace DbAccessAP
{
    partial class EditTodoForm
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
            titleTextBox = new TextBox();
            detailsTextBox = new TextBox();
            staffComboBox = new ComboBox();
            deadlineDateTimePicker = new DateTimePicker();
            titleLabel = new Label();
            detailsLabel = new Label();
            staffLabel = new Label();
            DeadlineLabel = new Label();
            editButton = new Button();
            SuspendLayout();
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(70, 28);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(513, 23);
            titleTextBox.TabIndex = 0;
            // 
            // detailsTextBox
            // 
            detailsTextBox.Location = new Point(70, 68);
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(513, 23);
            detailsTextBox.TabIndex = 1;
            // 
            // staffComboBox
            // 
            staffComboBox.FormattingEnabled = true;
            staffComboBox.Location = new Point(70, 104);
            staffComboBox.Name = "staffComboBox";
            staffComboBox.Size = new Size(98, 23);
            staffComboBox.TabIndex = 2;
            // 
            // deadlineDateTimePicker
            // 
            deadlineDateTimePicker.Format = DateTimePickerFormat.Short;
            deadlineDateTimePicker.Location = new Point(70, 139);
            deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            deadlineDateTimePicker.Size = new Size(134, 23);
            deadlineDateTimePicker.TabIndex = 3;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.ForeColor = SystemColors.ActiveCaptionText;
            titleLabel.Location = new Point(21, 31);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(43, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "タイトル";
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.ForeColor = SystemColors.ActiveCaptionText;
            detailsLabel.Location = new Point(33, 71);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(31, 15);
            detailsLabel.TabIndex = 5;
            detailsLabel.Text = "詳細";
            // 
            // staffLabel
            // 
            staffLabel.AutoSize = true;
            staffLabel.ForeColor = SystemColors.ActiveCaptionText;
            staffLabel.Location = new Point(21, 108);
            staffLabel.Name = "staffLabel";
            staffLabel.Size = new Size(43, 15);
            staffLabel.TabIndex = 6;
            staffLabel.Text = "従業員";
            // 
            // DeadlineLabel
            // 
            DeadlineLabel.AutoSize = true;
            DeadlineLabel.ForeColor = SystemColors.ActiveCaptionText;
            DeadlineLabel.Location = new Point(21, 145);
            DeadlineLabel.Name = "DeadlineLabel";
            DeadlineLabel.Size = new Size(43, 15);
            DeadlineLabel.TabIndex = 7;
            DeadlineLabel.Text = "期限日";
            // 
            // editButton
            // 
            editButton.ForeColor = SystemColors.ActiveCaptionText;
            editButton.Location = new Point(508, 141);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 8;
            editButton.Text = "編集";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += button1_Click;
            // 
            // EditTodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(620, 192);
            Controls.Add(editButton);
            Controls.Add(DeadlineLabel);
            Controls.Add(staffLabel);
            Controls.Add(detailsLabel);
            Controls.Add(titleLabel);
            Controls.Add(deadlineDateTimePicker);
            Controls.Add(staffComboBox);
            Controls.Add(detailsTextBox);
            Controls.Add(titleTextBox);
            ForeColor = SystemColors.ControlDarkDark;
            Name = "EditTodoForm";
            Text = "ToDoリスト編集";
            Load += TodoEditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox titleTextBox;
        private TextBox detailsTextBox;
        private ComboBox staffComboBox;
        private DateTimePicker deadlineDateTimePicker;
        private Label titleLabel;
        private Label detailsLabel;
        private Label staffLabel;
        private Label DeadlineLabel;
        private Button editButton;
    }
}