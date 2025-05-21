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
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbAccessAP
{
    /// <summary>
    /// 従業員情報の変更画面
    /// </summary>
    public partial class EditEmployeeForm : Form
    {
        /// <summary>
        /// 社員ID
        /// </summary>
        string employeeId;

        /// <summary>
        /// IDの取得
        /// </summary>
        /// <param name="employee">社員ID</param>
        public EditEmployeeForm(string employee)
        {
            InitializeComponent();
            employeeId = employee;
        }

        /// <summary>
        /// 初期表示
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditForm1_Load(object sender, EventArgs e)
        {
            // 取得の表示設定
            GetEmployee();
        }

        /// <summary>
        /// 登録ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            // 空白のチェック
            if (!CheckEmployee())
            {
                // 空白がある場合、処理を停止
                return;
            }

            // アップデート処理
            EditEmployee();
        }

        /// <summary>
        /// 従業員情報の取得とコンボボックスの設定
        /// </summary>
        private void GetEmployee()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;

                // 選択した従業員名と年齢を表示
                sql = "SELECT * FROM employees WHERE id = '" + employeeId + "'";
                DataTable employeeData1 = dbHelper.ExecuteQuery(connection, sql);
                nameTextBox.Text = employeeData1.Rows[0]["name"].ToString();
                ageTextBox.Text = employeeData1.Rows[0]["age"].ToString();

                // departmentsから名前の取得
                sql = "SELECT * FROM departments";
                DataTable employeeData2 = dbHelper.ExecuteQuery(connection, sql);
                dtEditForm.DataSource = employeeData2;

                // 画面に表示する項目を設定
                this.dtEditForm.DisplayMember = "name";

                // リンクさせるための値を設定
                this.dtEditForm.ValueMember = "id";

                // 取得したデータを０行目に表示
                this.dtEditForm.SelectedValue = employeeData1.Rows[0]["department_id"].ToString();
            }
        }

        /// <summary>
        /// 従業員の編集処理
        /// </summary>
        private void EditEmployee()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;
                string setCombobox = dtEditForm.SelectedValue.ToString();
                sql = "UPDATE employees SET name = '" + nameTextBox.Text + "' , age = " + ageTextBox.Text + " , department_id = " + setCombobox + " WHERE id = '" + employeeId + "'";
                dbHelper.ExecuteNonQuery(connection, sql);

                // 登録完了メッセージ表示
                MessageBox.Show("編集が完了いたしました");
            }
        }

        /// <summary>
        /// テキストボックスが空白の場合
        /// </summary>
        private bool CheckEmployee()

        {
            // 従業員名が未入力の場合
            if (nameTextBox.Text == "")
            {
                MessageBox.Show("従業員名のの入力がありません。記載してください");
                return false;
            }

            // 年齢が未入力の場合
            if (ageTextBox.Text == "")
            {
                MessageBox.Show("年齢の入力がありません。記載してください");
                return false;
            }

            // 部署が未入力の場合
            if (dtEditForm.Text == "")
            {
                MessageBox.Show("部署を選択してください");
                return false;
            }
            return true;
        }
    }
}
