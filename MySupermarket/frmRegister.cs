using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MySupermarket
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        string hint = "温馨提示";

        //账号密码非空验证
        public bool Verify()
        {
            if (this.txtAccount.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入用户名！", hint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtAccount.Focus();    //获取焦点
                return false;
            }
            else if (this.txtPassword.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请输入密码！", hint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtPassword.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        //验证登入账号和密码
        public bool Enter()
        {
            //创建数据库连接
            DBHelper db = new DBHelper();
            //数据库查询语句
            string sql = string.Format("SELECT COUNT(*) FROM [dbo].[User] WHERE UserName = '{0}' AND PassWord = '{1}'", this.txtAccount.Text.Trim(), this.txtPassword.Text.Trim());

            try
            {
                SqlCommand comm = new SqlCommand(sql, db.Connection);
                //打开数据连接
                db.OpenConnection();
                //执行命令
                int i = (int)comm.ExecuteScalar();
                if (i > 0)
                {
                    MessageBox.Show("登入成功！", hint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("账号或密码错误！", hint, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                //关闭数据库连接
                db.CloseConnection();
            }


        }

        //登录
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Verify())       //非空验证
            {
                if (Enter())     //验证账号密码
                {
                    frmMerchandise mer = new frmMerchandise();
                    mer.userName = txtAccount.Text.Trim();            // 值传递
                    mer.userPwd = txtPassword.Text.Trim();
                    mer.Show();                                       //超市商品管理窗体打开窗体
                    this.Hide();                                      //隐藏当前窗体

                }
            }
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {

        }
    }
}
