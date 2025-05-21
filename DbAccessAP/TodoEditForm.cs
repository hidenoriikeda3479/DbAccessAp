using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbAccessAP.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbAccessAP
{
    /// <summary>
    /// TODOリスト編集画面
    /// </summary>
    public partial class EditTodoForm : Form
    {
        /// <summary>
        /// 社員ID
        /// </summary>
        string todoId;

        /// <summary>
        /// IDの取得
        /// </summary>
        /// <param name="todoListId">社員ID</param>
        public EditTodoForm(string todoListId)
        {
            InitializeComponent();
            todoId = todoListId;
        }

        /// <summary>
        /// TODOリスト編集ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 空白のチェック
            CheckTodolist();

            // アップデート処理
            EditTodoList();
        }

        /// <summary>
        /// TODOリストのフォームロード処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodoEditForm_Load(object sender, EventArgs e)
        {
            // 取得の表示設定
            GetTodolist();
        }

        /// <summary>
        /// TODOリストの編集処理
        /// </summary>
        private void EditTodoList()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;
                string setCombobox = staffComboBox.SelectedValue.ToString();
                sql = "UPDATE Todos SET Title = '" + titleTextBox.Text + "' , Description = '" + detailsTextBox.Text + "' , EmployeeId = " + setCombobox + " , DueDate = '" + deadlineDateTimePicker.Text + "' WHERE TodoId = '" + todoId + "'";
                dbHelper.ExecuteNonQuery(connection, sql);

                // 登録完了メッセージ表示
                MessageBox.Show("編集が完了いたしました");
            }
        }

        /// <summary>
        /// TODOリストのテキストボックスが空白の場合
        /// </summary>
        private void CheckTodolist()
        {
            // タイトルの入力が無い場合
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("タイトルの入力をしてください");
                return;
            }

            // 詳細の入力が無い場合
            if (detailsTextBox.Text == "")
            {
                MessageBox.Show("詳細の入力をしてください");
                return;
            }

            // 社員IDの入力が無い場合
            if (staffComboBox.Text == "")
            {
                MessageBox.Show("社員IDを選択してください");
                return;
            }

            // 現在日付を取得（年月日のみ）
            DateTime nowDate = DateTime.Now.Date;
            if (deadlineDateTimePicker.Value < nowDate)
            {
                MessageBox.Show("過去の日付になっています。今日以降の日付を設定してください。");
                return;
            }
        }

        /// <summary>
        /// TODOリストのデータの取得と表示
        /// </summary>
        private void GetTodolist()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;

                // 選択した従業員名と年齢を表示
                sql = "SELECT * FROM Todos WHERE Todos.TodoId = '" + todoId + "'";
                DataTable employeeData1 = dbHelper.ExecuteQuery(connection, sql);
                titleTextBox.Text = employeeData1.Rows[0]["Title"].ToString();
                detailsTextBox.Text = employeeData1.Rows[0]["Description"].ToString();

                // departmentsから名前の取得
                sql = "SELECT * FROM employees";
                DataTable employeeData2 = dbHelper.ExecuteQuery(connection, sql);
                staffComboBox.DataSource = employeeData2;

                // 画面に表示する項目を設定
                this.staffComboBox.DisplayMember = "name";

                // リンクさせるための値を設定
                this.staffComboBox.ValueMember = "id";

                // 取得したデータを０行目に表示
                this.staffComboBox.SelectedValue = employeeData1.Rows[0]["EmployeeId"].ToString();

                // 取得した期限日の表示
                this.deadlineDateTimePicker.Text = employeeData1.Rows[0]["DueDate"].ToString();
            }
        }
    }
}
