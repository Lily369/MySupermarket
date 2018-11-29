using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace MySupermarket
{
    /// <summary>
    /// 此类维护数据库连接字符串和Connection对象
    /// </summary>
    class DBHelper
    {
        //数据库连接字符串
        private string connString = "Data Source=.;Initial Catalog=SuperMarket;User ID=sa;Pwd=sa";

        //数据库连接Connection对象
        private SqlConnection connection;

        /// <summary>
        ///Connection对象
        /// </summary>
        public SqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new SqlConnection(connString);
                }
                return connection;
            }
        }

        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            else if (connection.State == ConnectionState.Broken)
            {
                connection.Close();
                connection.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void CloseConnection()
        {
            if (connection.State == ConnectionState.Open || connection.State == ConnectionState.Broken)
            {
                connection.Close();
            }
        }
    }
}
