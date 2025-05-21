namespace DbAccessAP
{
    partial class InitialScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            employeeDataGridView = new DataGridView();
            EmployeeTextBox = new TextBox();
            label1 = new Label();
            getEmployeeButton = new Button();
            label2 = new Label();
            entryEmployeeButton = new Button();
            entryTodoButton = new Button();
            getTodoButton = new Button();
            DepartmentComboBox = new ComboBox();
            getDepartmentButton = new Button();
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).BeginInit();
            SuspendLayout();
            // 
            // employeeDataGridView
            // 
            employeeDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeDataGridView.Location = new Point(31, 92);
            employeeDataGridView.Name = "employeeDataGridView";
            employeeDataGridView.Size = new Size(585, 335);
            employeeDataGridView.TabIndex = 0;
            employeeDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // EmployeeTextBox
            // 
            EmployeeTextBox.Location = new Point(92, 17);
            EmployeeTextBox.Name = "EmployeeTextBox";
            EmployeeTextBox.Size = new Size(121, 23);
            EmployeeTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ImageAlign = ContentAlignment.BottomLeft;
            label1.Location = new Point(31, 20);
            label1.Name = "label1";
            label1.Size = new Size(55, 15);
            label1.TabIndex = 2;
            label1.Text = "従業員名";
            // 
            // getEmployeeButton
            // 
            getEmployeeButton.Location = new Point(228, 49);
            getEmployeeButton.Name = "getEmployeeButton";
            getEmployeeButton.Size = new Size(75, 23);
            getEmployeeButton.TabIndex = 3;
            getEmployeeButton.Text = "検索";
            getEmployeeButton.UseVisualStyleBackColor = true;
            getEmployeeButton.Click += btnSearch_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 52);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 2;
            label2.Text = "部署名";
            // 
            // entryEmployeeButton
            // 
            entryEmployeeButton.Location = new Point(356, 20);
            entryEmployeeButton.Name = "entryEmployeeButton";
            entryEmployeeButton.Size = new Size(102, 22);
            entryEmployeeButton.TabIndex = 3;
            entryEmployeeButton.Text = "従業員登録";
            entryEmployeeButton.UseVisualStyleBackColor = true;
            entryEmployeeButton.Click += BtnEntry_Click;
            // 
            // entryTodoButton
            // 
            entryTodoButton.Location = new Point(487, 20);
            entryTodoButton.Name = "entryTodoButton";
            entryTodoButton.Size = new Size(129, 22);
            entryTodoButton.TabIndex = 4;
            entryTodoButton.Text = "ToDoリスト登録";
            entryTodoButton.UseVisualStyleBackColor = true;
            entryTodoButton.Click += TodolistEntry_Click;
            // 
            // getTodoButton
            // 
            getTodoButton.Location = new Point(487, 52);
            getTodoButton.Name = "getTodoButton";
            getTodoButton.Size = new Size(129, 22);
            getTodoButton.TabIndex = 5;
            getTodoButton.Text = "ToDoリスト一覧";
            getTodoButton.UseVisualStyleBackColor = true;
            getTodoButton.Click += button1_Click;
            // 
            // DepartmentComboBox
            // 
            DepartmentComboBox.FormattingEnabled = true;
            DepartmentComboBox.Location = new Point(92, 49);
            DepartmentComboBox.Name = "DepartmentComboBox";
            DepartmentComboBox.Size = new Size(121, 23);
            DepartmentComboBox.TabIndex = 6;
            // 
            // getDepartmentButton
            // 
            getDepartmentButton.Location = new Point(356, 52);
            getDepartmentButton.Name = "getDepartmentButton";
            getDepartmentButton.Size = new Size(102, 22);
            getDepartmentButton.TabIndex = 7;
            getDepartmentButton.Text = "部署一覧";
            getDepartmentButton.UseVisualStyleBackColor = true;
            getDepartmentButton.Click += button2_Click;
            // 
            // InitialScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 450);
            Controls.Add(getDepartmentButton);
            Controls.Add(DepartmentComboBox);
            Controls.Add(getTodoButton);
            Controls.Add(entryTodoButton);
            Controls.Add(entryEmployeeButton);
            Controls.Add(getEmployeeButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmployeeTextBox);
            Controls.Add(employeeDataGridView);
            Name = "InitialScreen";
            Text = "従業員検索";
            Load += InitialScreen_Load;
            ((System.ComponentModel.ISupportInitialize)employeeDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView employeeDataGridView;
        private TextBox EmployeeTextBox;
        private Label label1;
        private Button getEmployeeButton;
        private Label label2;
        private Button entryEmployeeButton;
        private Button entryTodoButton;
        private Button getTodoButton;
        private ComboBox DepartmentComboBox;
        private Button getDepartmentButton;
    }
}
