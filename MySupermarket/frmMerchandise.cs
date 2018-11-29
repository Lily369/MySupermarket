using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySupermarket
{
    public partial class frmMerchandise : Form
    {
        public frmMerchandise()
        {
            InitializeComponent();
        }

        public string userName;             //账号
        public string userPwd;              //密码

        string hint = "温馨提示";

        private void tsmiExit_Click(object sender, EventArgs e)     //退出
        {
            DialogResult result = MessageBox.Show("确定要退出吗?",hint,MessageBoxButtons.OKCancel,MessageBoxIcon.Information);
            if(result == DialogResult.OK)
            {
                Application.Exit();     //退出应用
            }
        }

        private void tsmiModificationPwd_Click(object sender, EventArgs e)      //修改密码
        {
            frmModificationPwd mo = new frmModificationPwd();
            mo.userName = this.userName;            //值传递
            mo.userPwd = this.userPwd;          
            mo.Show();
        }

        private void pbBeijing_Click(object sender, EventArgs e)        //京东狗单击事件
        {
            frmList list = new frmList();
            list.Show();
        }

        private void pbBeijing_MouseMove(object sender, MouseEventArgs e)       //鼠标悬浮
        {
            this.pbBeijing.BorderStyle = BorderStyle.FixedSingle;
            this.pbBeijing.BackColor = Color.Silver;
        }

        private void pbBeijing_MouseLeave(object sender, EventArgs e)           //鼠标离开
        {
            pbBeijing.BorderStyle = BorderStyle.None;
            pbBeijing.BackColor = Color.White;
        }

        private void pbShop_MouseLeave(object sender, EventArgs e)
        {
            pbShop.BorderStyle = BorderStyle.None;
            pbShop.BackColor = Color.White;
        }

        private void pbShop_MouseMove(object sender, MouseEventArgs e)
        {
            pbShop.BorderStyle = BorderStyle.FixedSingle;
            this.pbShop.BackColor = Color.Silver;
        }

        private void tsRegard_Click(object sender, EventArgs e)     //关于按键
        {
            frmRegard re = new frmRegard();
            re.Show();
        }


    }
}
