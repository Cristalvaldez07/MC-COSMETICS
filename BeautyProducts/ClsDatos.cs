using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bd_program
{
    public class clsDatos
    {
        public SqlConnection con = new SqlConnection(@"Data Source=VZCRISTAL\SQLEXPRESS;Initial Catalog=BellezaBD;Integrated Security=True");
        public DataTable consulta(string strSql)
        {
            DataTable dtTabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(strSql, con);
            da.Fill(dtTabla);
            return dtTabla;
        }


    }
}