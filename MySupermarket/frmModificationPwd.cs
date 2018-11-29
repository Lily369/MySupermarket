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
    public partial class frmModificationPwd : Form
    {
        public frmModificationPwd()
        {
            InitializeComponent();
        }

        public string userName;     //账号
        public string userPwd;      //密码


        string hint = string.Empty;   //验证密码消息框语句

        public bool Verify()        //非空验证与密码确认
        {
            if (this.txtPwd.Text.Trim().Equals(string.Empty))
            {
                hint = "请输入密码！";
                //获取焦点
                this.txtPwd.Focus();
                return false;
            }
            else if (this.txtPwd2.Text.Trim().Equals(string.Empty))
            {
                hint = "请输入新密码！";
                //获取焦点
                this.txtPwd2.Focus();
                return false;
            }
            else if (this.txtPwd3.Text.Trim().Equals(string.Empty))
            {
                hint = "请输入确认密码！";
                //获取焦点
                this.txtPwd3.Focus();
                return false;
            }
            else if (!this.txtPwd2.Text.Trim().Equals(this.txtPwd3.Text.Trim()))
            {
                hint = "两次密码输入不一致！";
                return false;
            }
            else if (!this.txtPwd.Text.Trim().Equals(userPwd))
            {
                hint = "原密码输入错误！";
                this.txtPwd.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }

        public void Amend()         //修改密码操作
        {
            string sql = "update [dbo].[User] set PassWord = '" + this.txtPwd2.Text.Trim() + "' Where UserName = '" + userName + "'";
            DBHelper db = new DBHelper();
            try
            {
                SqlCommand comm = new SqlCommand(sql, db.Connection);
                //打开数据库连接
                db.OpenConnection();
                //执行命令
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("修改成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭数据库连接
                db.CloseConnection();
            }
        }

        private void btnAmend_Click(object sender, EventArgs e)     //修改按钮单击事件
        {
            bool ly = Verify();
            if (!hint.Equals(string.Empty))
            {
                MessageBox.Show(hint, "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (ly)
            {
                Amend();        //进行修改密码
            }

        }

    }
}
