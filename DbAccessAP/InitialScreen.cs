using DbAccessAP.Common;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbAccessAP
{
    /// <summary>
    /// 従業員検索画面
    /// </summary>
    public partial class InitialScreen : Form
    {
        public InitialScreen()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 検索ボタン押下
        /// </summary>
        /// <param name="sender">コントロール情報</param>
        /// <param name="e">イベント情報</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // 検索処理
            GetEmployee();

            // カラム名の変更
            SetHeaderColumn();

            // カラムにボタン追加
            ModifyButton();
        }

        /// <summary>
        /// 従業員登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEntry_Click(object sender, EventArgs e)
        {
            // 登録画面
            ShowEmployeeEntryForm();
        }

        /// <summary>
        /// TODOリスト登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodolistEntry_Click(object sender, EventArgs e)
        {
            // TODOリスト登録画面
            ShowTodoListRegister();
        }

        /// <summary>
        /// TODOリスト一覧Button押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // TODOリスト検索画面
            ShowTodoListCheck();
        }

        /// <summary>
        /// 部署一覧ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // 部署登録画面
            ShowDepartmentEditFome();
        }

        /// <summary>
        /// フォームロード初期処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InitialScreen_Load(object sender, EventArgs e)
        {
            // コンボボックスの設定
            SettingsCombobox();
        }

        /// <summary>
        /// データグリップビューボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView btnClick = (DataGridView)sender;
            // 「Button」列がクリックされた場合
            if (btnClick.Columns[e.ColumnIndex].Name == "Button")
            {
                var employeeformId = employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                EditEmployeeForm employeeform = new EditEmployeeForm(employeeformId);
                employeeform.Show();
            }
        }

        private void GetEmployee()
        {
            // DataGridView初期化（データクリア）
            employeeDataGridView.Columns.Clear();

            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;
                sql = "SELECT employees.id ,employees.name , employees.age , departments.name FROM employees INNER JOIN departments ON employees.department_id = departments.id WHERE 1 = 1";

                //　従業員名のみ入力されている場合
                if (EmployeeTextBox.Text != "")
                {
                    sql += " AND employees.name like '%" + EmployeeTextBox.Text + "%'";
                }

                //　部署名のみ入力されている場合
                if (DepartmentComboBox.SelectedValue != null)
                {
                    string setCombobox = DepartmentComboBox.SelectedValue.ToString();
                    sql += " AND departments.id = '" + setCombobox + "'";
                }
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                employeeDataGridView.DataSource = employeeData;
            }
        }

        /// <summary>
        /// カラム名の編集と幅の調整
        /// </summary>
        private void SetHeaderColumn()
        {
            // すべての列の幅を自動で調整する
            employeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // カラムの表示名の変更
            var cgId = employeeDataGridView.Columns["id"];
            cgId.HeaderText = "ID";

            var cgName = employeeDataGridView.Columns["name"];
            cgName.HeaderText = "従業員名";

            var cgDepartment = employeeDataGridView.Columns["name1"];
            cgDepartment.HeaderText = "部署";

            var cgAig = employeeDataGridView.Columns["age"];
            cgAig.HeaderText = "年齢";
        }

        /// <summary>
        /// コンボボックスの設定
        /// </summary>
        private void SettingsCombobox()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                // departmentsから名前の取得
                string sql = string.Empty;
                sql = "SELECT * FROM departments";
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                DepartmentComboBox.DataSource = employeeData;

                // 画面に表示する項目を設定
                this.DepartmentComboBox.DisplayMember = "name";

                // リンクさせるための値を設定
                this.DepartmentComboBox.ValueMember = "id";

                // 選択を解除
                this.DepartmentComboBox.SelectedValue = -1;
            }
        }

        /// <summary>
        /// カラムに編集ボタンの追加
        /// </summary>
        private void ModifyButton()
        {
            {
                // DataGridViewButtonColumnの作成
                DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
                Update.Name = "Button";

                // 全てのボタンに「編集」と表示
                Update.UseColumnTextForButtonValue = true;
                Update.Text = "編集";

                // DataGridViewに追加
                employeeDataGridView.Columns.Add(Update);
            }
        }

        /// <summary>
        /// 従業員登録画面へ画面遷移
        /// </summary>
        private void ShowEmployeeEntryForm()
        {
            // 新規従業員情報の登録フォームへ画面遷移する処理
            EntryForm entryForm = new EntryForm();
            entryForm.Show();
        }

        /// <summary>
        /// TODOリスト登録画面へ画面遷移
        /// </summary>
        private void ShowTodoListRegister()
        {
            // ToDoリストの登録フォームへ画面遷移する処理
            TodoForm todoForm = new TodoForm();
            todoForm.Show();
        }

        /// <summary>
        /// TODOリスト検索画面へ画面遷移
        /// </summary>
        private void ShowTodoListCheck()
        {
            // ToDoリストのフォームへ画面遷移する処理
            GetTodoFoam getTodoFoam = new GetTodoFoam();
            getTodoFoam.Show();
        }

        /// <summary>
        /// 部署登録画面へ画面遷移
        /// </summary>
        private void ShowDepartmentEditFome()
        {
            // 部署新規登録フォームへ画面遷移する処理
            DepartmentScreenForm departmentScreenForm = new DepartmentScreenForm();
            departmentScreenForm.Show();
        }
    }
}
