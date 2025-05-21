namespace DbAccessAP
{
    partial class GetTodoFoam
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
            todoDataGridView = new DataGridView();
            employeeNameTextBox = new ComboBox();
            departmentNameBox = new ComboBox();
            getTodoListButton = new Button();
            employeeNameLabel = new Label();
            departmentNameLabel = new Label();
            TodoTitletTextBox = new TextBox();
            titleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)todoDataGridView).BeginInit();
            SuspendLayout();
            // 
            // todoDataGridView
            // 
            todoDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todoDataGridView.Location = new Point(25, 94);
            todoDataGridView.Name = "todoDataGridView";
            todoDataGridView.Size = new Size(525, 313);
            todoDataGridView.TabIndex = 0;
            todoDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // employeeNameTextBox
            // 
            employeeNameTextBox.FormattingEnabled = true;
            employeeNameTextBox.Location = new Point(86, 48);
            employeeNameTextBox.Name = "employeeNameTextBox";
            employeeNameTextBox.Size = new Size(121, 23);
            employeeNameTextBox.TabIndex = 1;
            // 
            // departmentNameBox
            // 
            departmentNameBox.FormattingEnabled = true;
            departmentNameBox.Location = new Point(301, 48);
            departmentNameBox.Name = "departmentNameBox";
            departmentNameBox.Size = new Size(121, 23);
            departmentNameBox.TabIndex = 2;
            // 
            // getTodoListButton
            // 
            getTodoListButton.Location = new Point(475, 47);
            getTodoListButton.Name = "getTodoListButton";
            getTodoListButton.Size = new Size(75, 23);
            getTodoListButton.TabIndex = 3;
            getTodoListButton.Text = "検索";
            getTodoListButton.UseVisualStyleBackColor = true;
            getTodoListButton.Click += button1_Click;
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.AutoSize = true;
            employeeNameLabel.Location = new Point(25, 51);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(55, 15);
            employeeNameLabel.TabIndex = 4;
            employeeNameLabel.Text = "従業員名";
            // 
            // departmentNameLabel
            // 
            departmentNameLabel.AutoSize = true;
            departmentNameLabel.Location = new Point(252, 51);
            departmentNameLabel.Name = "departmentNameLabel";
            departmentNameLabel.Size = new Size(43, 15);
            departmentNameLabel.TabIndex = 5;
            departmentNameLabel.Text = "部署名";
            // 
            // TodoTitletTextBox
            // 
            TodoTitletTextBox.Location = new Point(86, 12);
            TodoTitletTextBox.Name = "TodoTitletTextBox";
            TodoTitletTextBox.Size = new Size(336, 23);
            TodoTitletTextBox.TabIndex = 6;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(25, 15);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(55, 15);
            titleLabel.TabIndex = 7;
            titleLabel.Text = "タイトル名";
            // 
            // GetTodoFoam
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 419);
            Controls.Add(titleLabel);
            Controls.Add(TodoTitletTextBox);
            Controls.Add(departmentNameLabel);
            Controls.Add(employeeNameLabel);
            Controls.Add(getTodoListButton);
            Controls.Add(departmentNameBox);
            Controls.Add(employeeNameTextBox);
            Controls.Add(todoDataGridView);
            Name = "GetTodoFoam";
            Text = "ToDoリスト検索";
            Load += ToDoList_Load;
            ((System.ComponentModel.ISupportInitialize)todoDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView todoDataGridView;
        private ComboBox employeeNameTextBox;
        private ComboBox departmentNameBox;
        private Button getTodoListButton;
        private Label employeeNameLabel;
        private Label departmentNameLabel;
        private TextBox TodoTitletTextBox;
        private Label titleLabel;
    }
}