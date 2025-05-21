using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbAccessAP.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DbAccessAP
{
    public partial class GetTodoFoam : Form
    {
        public GetTodoFoam()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToDoList_Load(object sender, EventArgs e)
        {
            // TODOリストの取得
            GetTodolist();

            // コンボボックスの設定
            SettingsCombobox();

            // カラム名の変更
            SetHeaderColumn();

            // カラムにボタン追加
            ModifyButton();
        }

        /// <summary>
        /// 検索ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // TODO情報の取得と設定
            GetEmployee();

            // カラム名の変更
            SetHeaderColumn();

            // カラムにボタン追加
            ModifyButton();
        }

        /// <summary>
        /// データグリッドビューボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                DataGridView btnClick = (DataGridView)sender;
                //「Button1」列がクリックされた場合(編集ボタン)
                if (btnClick.Columns[e.ColumnIndex].Name == "Button1")
                {
                    // 何行目、何列目のデータを遷移先に渡す処理
                    var editTodoId = todoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    EditTodoForm editTodoForm = new EditTodoForm(editTodoId);
                    editTodoForm.Show();
                }

                //「Button2」列がクリックされた場合(クリアボタン)
                if (btnClick.Columns[e.ColumnIndex].Name == "Button2")
                {
                    string sql = string.Empty;

                    // ０行目のデータを取得
                    var rowIndex = todoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                    // SQLserverから削除（DELETE文）
                    sql = "DELETE FROM Todos WHERE TodoId = " + rowIndex + ";";
                    DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                    todoDataGridView.DataSource = employeeData;

                    // 初期表示
                    GetTodolist();

                    // カラム名の変更
                    SetHeaderColumn();

                    // カラムにボタン追加
                    ModifyButton();
                }
            }
        }

        /// <summary>
        /// TODO情報の取得
        /// </summary>
        private void GetTodolist()
        {
            // DataGridView初期化（データクリア）
            todoDataGridView.Columns.Clear();

            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                // 社員名、部署、ToDoリストのタイトルと詳細、期限日を常時表示
                string sql = string.Empty;
                sql = "SELECT Todos.TodoId , employees.name , departments.name , Todos.Title , Todos.Description, Todos.DueDate FROM employees INNER JOIN departments ON employees.department_id = departments.id INNER JOIN Todos ON employees.id = EmployeeId ;";
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                todoDataGridView.DataSource = employeeData;
            }
        }

        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        private void SettingsCombobox()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                // コンボボックスに表示
                // employeesから名前の取得
                string eName = string.Empty;
                eName = "SELECT * FROM employees";
                DataTable employeeData2 = dbHelper.ExecuteQuery(connection, eName);
                employeeNameTextBox.DataSource = employeeData2;

                // 画面に表示する項目を設定
                this.employeeNameTextBox.DisplayMember = "name";

                // リンクさせるための値を設定
                this.employeeNameTextBox.ValueMember = "id";

                // 選択を解除
                this.employeeNameTextBox.SelectedValue = -1;

                // departmentsから名前の取得
                string dName = string.Empty;
                dName = "SELECT * FROM departments";
                DataTable employeeData3 = dbHelper.ExecuteQuery(connection, dName);
                departmentNameBox.DataSource = employeeData3;

                // 画面に表示する項目を設定
                this.departmentNameBox.DisplayMember = "name";

                // リンクさせるための値を設定
                this.departmentNameBox.ValueMember = "id";

                // 選択を解除
                this.departmentNameBox.SelectedValue = -1;
            }
        }

        /// <summary>
        /// カラム名の編集と幅の調整
        /// </summary>
        private void SetHeaderColumn()
        {
            // カラムの表示名の変更
            var cgId = todoDataGridView.Columns["TodoId"];
            cgId.HeaderText = "ID";

            var cgName = todoDataGridView.Columns["name"];
            cgName.HeaderText = "従業員名";

            var cgDepartment = todoDataGridView.Columns["name1"];
            cgDepartment.HeaderText = "部署";

            var cgTitle = todoDataGridView.Columns["Title"];
            cgTitle.HeaderText = "タイトル";

            var cgDescription = todoDataGridView.Columns["Description"];
            cgDescription.HeaderText = "詳細";

            var cgDueDate = todoDataGridView.Columns["DueDate"];
            cgDueDate.HeaderText = "期限日";

            // すべての列の幅を自動で調整する
            todoDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        /// <summary>
        /// カラムに編集ボタンの追加
        /// </summary>
        private void ModifyButton()
        {
            // DataGridViewButtonColumnの作成
            // 編集ボタン
            DataGridViewButtonColumn Update1 = new DataGridViewButtonColumn();
            Update1.Name = "Button1";

            // 全てのボタンに「編集」と表示
            Update1.UseColumnTextForButtonValue = true;
            Update1.Text = "編集";

            // DataGridViewに追加
            todoDataGridView.Columns.Add(Update1);

            // 削除ボタン
            DataGridViewButtonColumn Update2 = new DataGridViewButtonColumn();
            Update2.Name = "Button2";

            // 全てのボタンに「編集」と表示
            Update2.UseColumnTextForButtonValue = true;
            Update2.Text = "削除";

            // DataGridViewに追加
            todoDataGridView.Columns.Add(Update2);
        }

        /// <summary>
        /// 検索条件に従ってTODO情報を明細に設定する
        /// </summary>
        private void GetEmployee()
        {
            // DataGridView初期化（データクリア）
            todoDataGridView.Columns.Clear();

            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;
                sql = "SELECT Todos.TodoId , employees.name , departments.name , Todos.Title , Todos.Description, Todos.DueDate FROM employees INNER JOIN departments ON employees.department_id = departments.id INNER JOIN Todos ON employees.id = EmployeeId WHERE 1 = 1";

                // タイトルが入力されている場合
                if (TodoTitletTextBox.Text != "")
                {
                    sql += " AND Todos.Title like '%" + TodoTitletTextBox.Text + "%'";
                }

                // 社員名が入力されている場合
                if (employeeNameTextBox.SelectedValue != null)
                {
                    string setCombobox = employeeNameTextBox.SelectedValue.ToString();
                    sql += " AND employees.id = '" + setCombobox + "'";
                }

                // 部署名が入力されている場合
                if (departmentNameBox.SelectedValue != null)
                {
                    string setCombobox = departmentNameBox.SelectedValue.ToString();
                    sql += " AND departments.id = '" + setCombobox + "'";
                }
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                todoDataGridView.DataSource = employeeData;
            }
        }
    }
}
