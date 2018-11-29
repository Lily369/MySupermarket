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
    public partial class frmList : Form
    {
        public frmList()
        {
            InitializeComponent();
        }

        //创建数据集
        public DataSet ds;
        //声明DataAdapter
        SqlDataAdapter adapter;
        //创建数据库连接
        DBHelper db = new DBHelper();

        private void frmList_Load(object sender, EventArgs e)   //窗口加载事件
        {
            this.dgvShow.MultiSelect = false;   //只能选择一行
            Acquire();  //显示数据
        }

        //打折筛选
        public void Filtrate()
        {
            DataView dv = new DataView(ds.Tables["Commodity"]);

            //筛选条件
            string filtrate = string.Empty;
            if (tvType.SelectedNode.Level==1 && tvType.SelectedNode.Text.Equals("正价商品"))
            {
                filtrate = "IsDiscount = 0";
            }
            else if(tvType.SelectedNode.Level==1 && tvType.SelectedNode.Text.Equals("特价商品"))
            {
                filtrate = "IsDiscount = 1";
            }
            dv.RowFilter = filtrate;        //筛选条件
            dgvShow.DataSource = dv;        //绑定数据源
        }

        //获取数据
        public void Acquire()
        {
            string sql = @"SELECT CommodityID,CommodityName,S.SortName,CommodityPrice,IsDiscount,ReducedPrice
                            FROM CommoditySort AS S 
                            INNER JOIN Commodity AS L ON(S.SortID=L.SortID)";
            ds = new DataSet();
            adapter = new SqlDataAdapter(sql,db.Connection);
            //填充数据集
            adapter.Fill(ds, "Commodity");

            //绑定数据源
            this.dgvShow.DataSource = ds.Tables["Commodity"];

        }

        private void tvType_AfterSelect(object sender, TreeViewEventArgs e)     //当Treeview的根选中之后发生
        {
            Filtrate();
        }

        private void tsAdd_Click(object sender, EventArgs e)        //增加按钮
        {
            frmRedact re = new frmRedact();
            re.frmlist = this;
            re.Show();
        }

        private void tsAmend_Click(object sender, EventArgs e)      //修改按钮
        {
            frmRedact re = new frmRedact();
            re.id = Convert.ToInt32(dgvShow.SelectedRows[0].Cells[0].Value);        //获取当前选择的ID
            re.frmlist = this;
            re.Show();
        }

        public void Delete()     //删除操作
        {
            int id = Convert.ToInt32(dgvShow.SelectedRows[0].Cells[0].Value);       //获取商品ID

            string sql = "DELETE FROM Commodity WHERE CommodityID = "+id;

            try
            {
                SqlCommand comm = new SqlCommand(sql, db.Connection);
                db.OpenConnection();    //打开数据库连接
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    
                    MessageBox.Show("删除成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Acquire();  //刷新窗口
                }
                else
                {
                    MessageBox.Show("删除失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void tsDelete_Click(object sender, EventArgs e)     //删除按钮
        {
            string name = dgvShow.SelectedRows[0].Cells[1].Value.ToString();
            DialogResult result = MessageBox.Show("确定要删除商品名称为 "+name+" 吗?","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Delete();            //执行删除操作
                
            }
        }

        private void tsExit_Click(object sender, EventArgs e)   //退出按钮
        {
             DialogResult result = MessageBox.Show("确定要退出吗?","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
             if (result == DialogResult.OK)
             {
                 Application.Exit();
             }
        }

    }
}
