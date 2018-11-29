using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace MySupermarket
{
    public partial class frmRedact : Form
    {
        public frmList frmlist;
      
        public frmRedact()
        {
            InitializeComponent();
        }
        //声明数据集
        DataSet ds = new DataSet();    
        //数据库连接
        DBHelper db = new DBHelper();

        public int id = 0;   //商品ID

        //商品类别绑定
        public void Type()
        {
            string sql = "SELECT * FROM CommoditySort";

            //适配器
            SqlDataAdapter adapter = new SqlDataAdapter(sql,db.Connection);

            //填充数据集
            adapter.Fill(ds, "CommoditySort");

            //创建第一行
            DataRow row = ds.Tables["CommoditySort"].NewRow();
            row[0] = "-1";
            row[1] = "请选择";
            ds.Tables["CommoditySort"].Rows.InsertAt(row,0);

            //绑定数据
            cboType.ValueMember = "SortID";
            cboType.DisplayMember = "SortName";
            cboType.DataSource = ds.Tables["CommoditySort"];        
        }

        private void frmRedact_Load(object sender, EventArgs e)     //窗口加载
        {
            Type(); //商品类别绑定
            if (id != 0)
            {
                btnSava.Text = "修改";
                Mmp();     //显示商品信息
            }
        }

        public bool Judge()     //判断是特价是否选中
        {
            if (cbYN.Checked)
            {
                nuMoney.Enabled = true;
                return true;
            }
            else
            {
                nuMoney.Enabled = false;
                return false;
            }
        }

        private void cbYN_CheckedChanged(object sender, EventArgs e)        //当复选框值发生改变时
        {
            Judge();
        }

        public void Insertion()     //插入商品信息
        {
            bool ly = Judge();      //查看是否为特价
            double money = 0;       //特价价格
            int yy = 0;
            if (ly)
            {
                yy = 1;
                money = Convert.ToDouble(nuMoney.Value);
            }
            else
            {
                yy = 0;
                money = Convert.ToDouble(nuPrice.Value);
            }

            string sql = string.Format(@"INSERT Commodity(CommodityName, SortID, CommodityPrice, IsDiscount, ReducedPrice)
                                        VALUES('{0}',{1},{2},{3},{4});", txtName.Text.Trim(), cboType.SelectedValue, Convert.ToDouble(nuPrice.Value),yy,money);

            try
            {
                SqlCommand comm = new SqlCommand(sql, db.Connection);
                db.OpenConnection();
                int i = comm.ExecuteNonQuery();
                if(i>0)
                {
                    MessageBox.Show("插入成功！","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("插入失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnSava_Click(object sender, EventArgs e)      //保存按钮
        {
            if (!Verify())
            {
                MessageBox.Show(hint,"提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (Verify())   //非空验证
            {
                if (id != 0)
                {
                    Amend(); //修改商品信息方法
                    frmlist.Acquire();

                    this.Hide();
                }
                else
                {
                     Insertion();         //插入商品信息方法
                     frmlist.Acquire(); //刷新窗口
                     this.Hide();
                }
            }
        }

        string hint = string.Empty;
        
        public bool Verify()        //非空验证
        { 
            if(txtName.Text.Trim().Equals(string.Empty))
            {
                hint = "请输入商品名称！";
                txtName.Focus();    //获取焦点
                return false;
            }
            else if (Convert.ToInt32(cboType.SelectedValue) == -1)
            {
                hint = "请选择商品类型！";
                return false;
            }
            else if(Convert.ToInt32(nuPrice.Value)==0)
            {
                hint = "请输入价格！";
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)  //退出
        {
            
            this.Close();
        }

        public void Mmp()      //显示商品信息
        {
            string sql = "SELECT CommodityName,SortID,CommodityPrice,IsDiscount,ReducedPrice FROM Commodity WHERE CommodityID = "+id;

            try
            {
                SqlCommand comm = new SqlCommand(sql, db.Connection);
                db.OpenConnection();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtName.Text = reader["CommodityName"].ToString();  //商品名称框赋值
                    nuPrice.Value = Convert.ToDecimal(reader["CommodityPrice"]);
                    if (Convert.ToBoolean(reader["IsDiscount"]))        //判断是否为特价
                    {
                        cbYN.Checked = true;
                    }
                    nuMoney.Value = Convert.ToDecimal(reader["ReducedPrice"]);

                    cboType.SelectedValue = reader["SortID"].ToString();
                }
                reader.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
        }

        public void Amend()     //修改商品信息
        {
            int yy = 0;
            if(Judge())
            {
                yy = 1;
            }
            else
            {
                
                yy = 0;
            }
            if (!Judge())
            {
                nuMoney.Value = nuPrice.Value;
            }
            string sql = string.Format("UPDATE Commodity SET CommodityName='{0}',SortID={1},CommodityPrice={2},IsDiscount={3},ReducedPrice={4} WHERE CommodityID = {5} ", txtName.Text.Trim(), cboType.SelectedValue, Convert.ToDouble(nuPrice.Value), yy, Convert.ToDouble(nuMoney.Value),id);
            try
            {
                SqlCommand comm = new SqlCommand(sql, db.Connection);
                db.OpenConnection();
                int i = comm.ExecuteNonQuery();
                if (i > 0)
                {
                    MessageBox.Show("更新成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmList list = new frmList();
                    list.ds = new DataSet();
                    list.dgvShow.DataSource = list.ds.Tables["Commodity"];
                }
                else
                {
                    MessageBox.Show("更新失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                db.CloseConnection();
            }
            
        }

    }
}
