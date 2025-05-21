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
    /// 部署新規登録画面
    /// </summary>
    public partial class AddDepartmentRegisterForm : Form
    {
        public AddDepartmentRegisterForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void epartmentRegistrationButton_Click(object sender, EventArgs e)
        {
            // 登録処理
            GetDepartment();

            // 空白のチェック
            CheckDepartment();
        }

        /// <summary>
        /// 部署名の新規登録
        /// </summary>
        private void GetDepartment()
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;
                sql = "INSERT INTO departments(name)  VALUES ('" + addDepartmentTextBox.Text + "')";
                dbHelper.ExecuteNonQuery(connection, sql);

                // 登録完了メッセージ表示
                MessageBox.Show("登録が完了いたしました");
            }
        }

        /// <summary>
        /// テキストボックスの空白チェック
        /// </summary>
        private void CheckDepartment()
        {
            // 部署名の入力がない場合
            if (addDepartmentTextBox.Text == "")
            {
                MessageBox.Show("登録する部署名を入力してください");
                return;
            }
        }
    }
}
