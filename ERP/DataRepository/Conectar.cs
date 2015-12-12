using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ERP.DataRepository
{
    class Conectar
    {
        public SqlConnection conn = new SqlConnection(@"server = .\sqlexpress;
                    integrated security = true; database = ERP");
        public SqlConnection DbOpen()
        {
            conn.Open();
            return conn;
        }

        public SqlConnection DbClose()
        {
            conn.Close();
            return conn;
        }

        public SqlCommand Comando(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            return cmd;
        }
    }
}
