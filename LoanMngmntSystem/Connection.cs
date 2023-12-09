using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LoanMngmntSystem
{
    class Connection
    {
        static SqlConnection cn;
        static SqlCommand cmd;
        public static string cnstr = "Data Source=BINDIYA-PC;Initial Catalog=LoanMngmntSystem;Integrated Security=True";
        public static void AddUpdtDltOprtns(string Qry)
        {
            cn = new SqlConnection(cnstr);
            cn.Open();
            cmd = new SqlCommand(Qry, cn);
            cmd.ExecuteNonQuery();
            cn.Close();
            cn.Dispose();
            cmd.Dispose();
        }
    }
}
