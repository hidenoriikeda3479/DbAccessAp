using DbAccessAP.Common;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbAccessAP
{
    /// <summary>
    /// 従業員一覧
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// 従業員一覧の読み込み
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 検索ボタンクリックイベント
        /// </summary>
        /// <param name="sender">コントロール情報</param>
        /// <param name="e">イベント情報</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");

            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;

                sql = "SELECT * FROM employees";

                //　従業員名のみ入力されている場合
                if (textBox1.Text != "" && textBox2.Text == "")
                {
                    sql += " WHERE name = '" + textBox1.Text + "';";
                }

                //　部署名のみ入力されている場合
                if (textBox2.Text != "" && textBox1.Text == "")
                {
                    sql += " WHERE department = '" + textBox2.Text + "';";
                }

                //　従業員名と部署名が入力されている場合
                if (textBox1.Text != "" && textBox2.Text != "")
                {
                    sql += " WHERE name = '" + textBox1.Text + "' AND department = '" + textBox2.Text + "';";
                }

                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                dataGridView1.DataSource = employeeData;
            }
        }
        /// <summary>
        /// 新規登録ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnEntry_Click(object sender, EventArgs e)
        {
            // 新規従業員情報の登録フォームへ画面遷移する処理
            EntryForm form2 = new EntryForm();
            form2.Show();
        }

    }
}
