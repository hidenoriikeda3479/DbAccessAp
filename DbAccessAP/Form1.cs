using DbAccessAP.Common;
using System.Data;
using System.Windows.Forms;

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
            DatabaseHelper dbHelper = new DatabaseHelper("接続文字列");

            using (var connection = dbHelper.OpenConnection())
            {
                string sql = "SELECT EmployeeID, Name, Department, Position FROM Employees";
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                dataGridView1.DataSource = employeeData;
            }
        }
    }
}
