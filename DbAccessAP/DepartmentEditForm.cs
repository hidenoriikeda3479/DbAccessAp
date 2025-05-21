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

namespace DbAccessAP
{
    /// <summary>
    /// 部署の編集画面
    /// </summary>
    public partial class editDepartmentForm : Form
    {
        /// <summary>
        /// 社員ID
        /// </summary>
        string departmentId;

        /// <summary>
        /// IDの取得
        /// </summary>
        /// <param name="department">社員ID</param>
        public editDepartmentForm(string department)
        {
            InitializeComponent();
            departmentId = department;
        }

        /// <summary>
        /// 部署編集ボタン
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editButton_Click(object sender, EventArgs e)
        {
            // 部署の編集
            EditDepartment();
        }

        /// <summary>
        /// フォームの初期処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void departmentEditForm_Load(object sender, EventArgs e)
        {
            // 部署の取得
            GetDepartment();
        }

        /// <summary>
        /// 取得したデータの表示
        /// </summary>
        private void GetDepartment()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;

                // 選択した従業員名と年齢を表示
                sql = "SELECT * FROM departments WHERE id = '" + departmentId + "'";
                DataTable employeeData1 = dbHelper.ExecuteQuery(connection, sql);
                editDepartmentTextBox.Text = employeeData1.Rows[0]["name"].ToString();
            }
        }

        /// <summary>
        /// 部署名の更新
        /// </summary>
        private void EditDepartment()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;

                // 部署の入力が無い場合
                if (editDepartmentTextBox.Text == "")
                {
                    MessageBox.Show("編集する部署名を入力してください");
                    return;
                }
                sql = "UPDATE departments SET name = '" + editDepartmentTextBox.Text + "' WHERE id = " + departmentId + ";";
                dbHelper.ExecuteNonQuery(connection, sql);

                // 登録完了メッセージ表示
                MessageBox.Show("編集が完了いたしました");
            }
        }
    }
}
