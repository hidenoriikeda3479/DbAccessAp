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
    /// TODOリストの登録画面
    /// </summary>
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// TODO登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryButton2_Click(object sender, EventArgs e)
        {
            // 空白チェック
            if (!CheckTodolist())
            {
                return;
            }

            // 登録処理
            AddTodolist();
        }

        /// <summary>
        /// TODOリストのフォームロード処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TodoForm_Load(object sender, EventArgs e)
        {
            // コンボボックスの設定
            GetTodolist();
        }

        /// <summary>
        /// クリアボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // クリア処理
            ClearTodolist();
        }

        /// <summary>
        /// 従業員の登録処理
        /// </summary>
        private void AddTodolist()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;

                // Todosテーブルへ登録
                string keycb = nameComboBox.SelectedValue.ToString();
                sql = "INSERT INTO Todos(EmployeeId,Title,Description,DueDate) VALUES(" + keycb + ",'" + titleTextBox.Text + "','" + detailsTextBox.Text + "','" + deadlineDateTimePicker.Text + "')";
                dbHelper.ExecuteNonQuery(connection, sql);

                // 登録完了メッセージ表示
                MessageBox.Show("登録が完了いたしました");
            }
        }

        /// <summary>
        /// テキストボックスが空白の場合
        /// </summary>
        private bool CheckTodolist()
        {
            // タイトルの入力が無い場合
            if (titleTextBox.Text == "")
            {
                MessageBox.Show("タイトルの入力をしてください");
                return false;
            }

            // 詳細の入力が無い場合
            if (detailsTextBox.Text == "")
            {
                MessageBox.Show("詳細の入力をしてください");
                return false;
            }

            // 社員IDの入力が無い場合
            if (nameComboBox.Text == "")
            {
                MessageBox.Show("社員IDを選択してください");
                return false;
            }

            // 現在日付を取得（年月日のみ）
            DateTime nowDate = DateTime.Now.Date;
            if (deadlineDateTimePicker.Value < nowDate)
            {
                MessageBox.Show("過去の日付になっています。今日以降の日付を設定してください。");
                return false;
            }
            return true;
        }

        /// <summary>
        /// コンボボックスの初期設定
        /// </summary>
        private void GetTodolist()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                // departmentsから名前の取得
                string sql = string.Empty;
                sql = "SELECT * FROM employees";
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                nameComboBox.DataSource = employeeData;

                // 画面に表示する項目を設定
                this.nameComboBox.DisplayMember = "name";

                // リンクさせるための値を設定
                this.nameComboBox.ValueMember = "id";

                // 選択を解除
                this.nameComboBox.SelectedValue = -1;

                // 期限日の固定
                deadlineDateTimePicker.CustomFormat = "yyyy/MM/dd";
            }
        }

        /// <summary>
        /// テキストボックスとコンボボックスのクリア
        /// </summary>
        private void ClearTodolist()
        {
            titleTextBox.Text = string.Empty;
            detailsTextBox.Text = string.Empty;
            deadlineDateTimePicker.Text = string.Empty;
            nameComboBox.Text = string.Empty;
        }
    }
}
