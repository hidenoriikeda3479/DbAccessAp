using DbAccessAP.Common;
using System.Data;
using System.Windows.Forms;

namespace DbAccessAP
{
    /// <summary>
    /// �]�ƈ��ꗗ
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// �]�ƈ��ꗗ�̓ǂݍ���
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �����{�^���N���b�N�C�x���g
        /// </summary>
        /// <param name="sender">�R���g���[�����</param>
        /// <param name="e">�C�x���g���</param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            DatabaseHelper dbHelper = new DatabaseHelper("�ڑ�������");

            using (var connection = dbHelper.OpenConnection())
            {
                string sql = "SELECT EmployeeID, Name, Department, Position FROM Employees";
                DataTable employeeData = dbHelper.ExecuteQuery(connection, sql);
                dataGridView1.DataSource = employeeData;
            }
        }
    }
}
