namespace DbAccessAP
{
    partial class DepartmentScreenForm
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
            getDepartmentTextBox = new TextBox();
            getDepartmentLabel = new Label();
            getDepartmentButton = new Button();
            getDepartmentGridView = new DataGridView();
            addDepartmentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)getDepartmentGridView).BeginInit();
            SuspendLayout();
            // 
            // getDepartmentTextBox
            // 
            getDepartmentTextBox.Location = new Point(100, 21);
            getDepartmentTextBox.Name = "getDepartmentTextBox";
            getDepartmentTextBox.Size = new Size(173, 23);
            getDepartmentTextBox.TabIndex = 0;
            // 
            // getDepartmentLabel
            // 
            getDepartmentLabel.AutoSize = true;
            getDepartmentLabel.Location = new Point(51, 24);
            getDepartmentLabel.Name = "getDepartmentLabel";
            getDepartmentLabel.Size = new Size(43, 15);
            getDepartmentLabel.TabIndex = 1;
            getDepartmentLabel.Text = "部署名";
            // 
            // getDepartmentButton
            // 
            getDepartmentButton.Location = new Point(301, 21);
            getDepartmentButton.Name = "getDepartmentButton";
            getDepartmentButton.Size = new Size(75, 23);
            getDepartmentButton.TabIndex = 2;
            getDepartmentButton.Text = "検索";
            getDepartmentButton.UseVisualStyleBackColor = true;
            getDepartmentButton.Click += SearchButton_Click;
            // 
            // getDepartmentGridView
            // 
            getDepartmentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            getDepartmentGridView.Location = new Point(22, 89);
            getDepartmentGridView.Name = "getDepartmentGridView";
            getDepartmentGridView.Size = new Size(354, 260);
            getDepartmentGridView.TabIndex = 3;
            getDepartmentGridView.CellContentClick += departmentDataGridView_CellContentClick;
            // 
            // addDepartmentButton
            // 
            addDepartmentButton.Location = new Point(301, 50);
            addDepartmentButton.Name = "addDepartmentButton";
            addDepartmentButton.Size = new Size(75, 23);
            addDepartmentButton.TabIndex = 4;
            addDepartmentButton.Text = "登録";
            addDepartmentButton.UseVisualStyleBackColor = true;
            addDepartmentButton.Click += departmentRegisterButton_Click;
            // 
            // DepartmentScreenForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 371);
            Controls.Add(addDepartmentButton);
            Controls.Add(getDepartmentGridView);
            Controls.Add(getDepartmentButton);
            Controls.Add(getDepartmentLabel);
            Controls.Add(getDepartmentTextBox);
            Name = "DepartmentScreenForm";
            Text = "部署検索";
            ((System.ComponentModel.ISupportInitialize)getDepartmentGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox getDepartmentTextBox;
        private Label getDepartmentLabel;
        private Button getDepartmentButton;
        private DataGridView getDepartmentGridView;
        private Button addDepartmentButton;
    }
}