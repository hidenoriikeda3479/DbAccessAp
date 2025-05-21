namespace DbAccessAP
{
    partial class TodoForm
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
            deadlineDateTimePicker = new DateTimePicker();
            detailsTextBox = new TextBox();
            titleTextBox = new TextBox();
            detailsLabel = new Label();
            titleLabel = new Label();
            deadlineLabel3 = new Label();
            foreignKeyLabel = new Label();
            nameComboBox = new ComboBox();
            entryButton2 = new Button();
            oreignKeyLabel = new Label();
            clearButton = new Button();
            SuspendLayout();
            // 
            // deadlineDateTimePicker
            // 
            deadlineDateTimePicker.Format = DateTimePickerFormat.Short;
            deadlineDateTimePicker.Location = new Point(74, 112);
            deadlineDateTimePicker.Name = "deadlineDateTimePicker";
            deadlineDateTimePicker.Size = new Size(164, 23);
            deadlineDateTimePicker.TabIndex = 0;
            // 
            // detailsTextBox
            // 
            detailsTextBox.Location = new Point(74, 54);
            detailsTextBox.Name = "detailsTextBox";
            detailsTextBox.Size = new Size(435, 23);
            detailsTextBox.TabIndex = 1;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(74, 25);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(435, 23);
            titleTextBox.TabIndex = 2;
            // 
            // detailsLabel
            // 
            detailsLabel.AutoSize = true;
            detailsLabel.Location = new Point(37, 57);
            detailsLabel.Name = "detailsLabel";
            detailsLabel.Size = new Size(31, 15);
            detailsLabel.TabIndex = 3;
            detailsLabel.Text = "詳細";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(25, 28);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(43, 15);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "タイトル";
            // 
            // deadlineLabel3
            // 
            deadlineLabel3.AutoSize = true;
            deadlineLabel3.Location = new Point(25, 118);
            deadlineLabel3.Name = "deadlineLabel3";
            deadlineLabel3.Size = new Size(43, 15);
            deadlineLabel3.TabIndex = 5;
            deadlineLabel3.Text = "期限日";
            // 
            // foreignKeyLabel
            // 
            foreignKeyLabel.AutoSize = true;
            foreignKeyLabel.Location = new Point(150, 292);
            foreignKeyLabel.Name = "foreignKeyLabel";
            foreignKeyLabel.Size = new Size(19, 15);
            foreignKeyLabel.TabIndex = 6;
            foreignKeyLabel.Text = "　";
            // 
            // nameComboBox
            // 
            nameComboBox.FormattingEnabled = true;
            nameComboBox.Location = new Point(74, 83);
            nameComboBox.Name = "nameComboBox";
            nameComboBox.Size = new Size(164, 23);
            nameComboBox.TabIndex = 8;
            // 
            // entryButton2
            // 
            entryButton2.Location = new Point(438, 106);
            entryButton2.Name = "entryButton2";
            entryButton2.Size = new Size(71, 27);
            entryButton2.TabIndex = 9;
            entryButton2.Text = "登録";
            entryButton2.UseVisualStyleBackColor = true;
            entryButton2.Click += entryButton2_Click;
            // 
            // oreignKeyLabel
            // 
            oreignKeyLabel.AutoSize = true;
            oreignKeyLabel.Location = new Point(13, 86);
            oreignKeyLabel.Name = "oreignKeyLabel";
            oreignKeyLabel.Size = new Size(55, 15);
            oreignKeyLabel.TabIndex = 10;
            oreignKeyLabel.Text = "従業員名";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(357, 106);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(75, 27);
            clearButton.TabIndex = 11;
            clearButton.Text = "クリア";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += deleteButton_Click;
            // 
            // TodoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(543, 158);
            Controls.Add(clearButton);
            Controls.Add(oreignKeyLabel);
            Controls.Add(entryButton2);
            Controls.Add(nameComboBox);
            Controls.Add(foreignKeyLabel);
            Controls.Add(deadlineLabel3);
            Controls.Add(titleLabel);
            Controls.Add(detailsLabel);
            Controls.Add(titleTextBox);
            Controls.Add(detailsTextBox);
            Controls.Add(deadlineDateTimePicker);
            Name = "TodoForm";
            Text = "ToDoリスト登録";
            Load += TodoForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker deadlineDateTimePicker;
        private TextBox detailsTextBox;
        private TextBox titleTextBox;
        private Label detailsLabel;
        private Label titleLabel;
        private Label deadlineLabel3;
        private Label foreignKeyLabel;
        private ComboBox nameComboBox;
        private Button entryButton2;
        private Label oreignKeyLabel;
        private Button clearButton;
    }
}