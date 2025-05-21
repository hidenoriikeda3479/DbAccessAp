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
    /// 部署検索画面
    /// </summary>
    public partial class DepartmentScreenForm : Form
    {
        public DepartmentScreenForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 検索ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            // 部署検索
            GetDepartment();

            // カラム名の変更
            SetHeaderColumn();

            // カラムにボタン追加
            ModifyButton();
        }

        /// <summary>
        /// カラム内の編集ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void departmentDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                DataGridView btnClick = (DataGridView)sender;

                //「Button」列がクリックされた場合
                if (btnClick.Columns[e.ColumnIndex].Name == "Button")
                {
                    var departmentId = getDepartmentGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    editDepartmentForm departmentForm = new editDepartmentForm(departmentId);
                    departmentForm.Show();
                }
            }
        }

        /// <summary>
        /// 登録ボタン押下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void departmentRegisterButton_Click(object sender, EventArgs e)
        {
            // 部署新規登録画面
            AddDepartmentButton();
        }

        /// <summary>
        /// 部署名の検索
        /// </summary>
        private void GetDepartment()
        {
            // DataGridView初期化（データクリア）
            getDepartmentGridView.Columns.Clear();

            DatabaseHelper dbHelper = new DatabaseHelper("Server=LAPTOP-UPM585DU;Database=master;Integrated Security=True;TrustServerCertificate=True;");
            using (var connection = dbHelper.OpenConnection())
            {
                string sql = string.Empty;
                sql = "SELECT * FROM departments ";

                // テキストボックスに部署名の記載がある場合
                if (getDepartmentTextBox.Text != "")
                {
                    sql += " WHERE name LIKE '%" + getDepartmentTextBox.Text + "%' ";
                }

                sql += " ORDER BY id ASC;";

                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                getDepartmentGridView.DataSource = employeeData;
            }
        }

        /// <summary>
        /// カラム名の編集と幅の調整
        /// </summary>
        private void SetHeaderColumn()
        {
            // すべての列の幅を自動で調整する
            getDepartmentGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // カラムの表示名の変更
            var cgId = getDepartmentGridView.Columns["id"];
            cgId.HeaderText = "ID";

            var cgName = getDepartmentGridView.Columns["name"];
            cgName.HeaderText = "部署名";
        }

        /// <summary>
        /// カラムに編集ボタンの追加
        /// </summary>
        private void ModifyButton()
        {
            // DataGridViewButtonColumnの作成
            DataGridViewButtonColumn Update = new DataGridViewButtonColumn();
            Update.Name = "Button";

            // 全てのボタンに「編集」と表示
            Update.UseColumnTextForButtonValue = true;
            Update.Text = "編集";

            // DataGridViewに追加
            getDepartmentGridView.Columns.Add(Update);
        }

        /// <summary>
        /// 新規登録画面への画面遷移処理
        /// </summary>
        private void AddDepartmentButton()
        {
            // 部署登録フォームへ画面遷移する処理
            AddDepartmentRegisterForm departmentForm = new AddDepartmentRegisterForm();
            departmentForm.Show();
        }
    }
}
