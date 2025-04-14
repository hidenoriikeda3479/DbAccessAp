using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbAccessAP.Common;

namespace DbAccessAP
{
    public partial class EntryForm : Form
    {
        public EntryForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 登録ボタン押下処理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void entryButton1_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            {
                using (var connection = dbHelper.OpenConnection())
                {
                    string sql = string.Empty;

                    //　いずれかの入力が無かった場合の処理（エラーメッセージ）
                    //　従業員名の入力が無い場合
                    if (employeeNameInput.Text == "")
                    {
                        MessageBox.Show("従業員名入力をしてください");
                        return;
                    }

                    //　年齢の入力がない場合
                    else if (ageInput.Text == "")
                    {
                        MessageBox.Show("年齢入力をしてください");
                        return;
                    }

                    //　部署名の入力がない場合
                    else if (departmentNameInput.Text == "")
                    {
                        MessageBox.Show("部署名入力をしてください");
                        return;
                    }

                    //　年齢に入力がある場合
                    if (ageInput.Text != "")
                    {
                        int age;
                        if (!int.TryParse(ageInput.Text, out age))
                        {
                            MessageBox.Show("適切な数字を入力してください。");
                            return;
                        } 
                    }
                    sql = "INSERT INTO employees(name, age, department) VALUES ('" + employeeNameInput.Text + "', " + ageInput.Text + ", '" + departmentNameInput.Text + "')";

                    dbHelper.ExecuteNonQuery(connection, sql);

                    // 登録完了メッセージ表示
                    MessageBox.Show("登録完了");
                }
            }
        }
    }
}
