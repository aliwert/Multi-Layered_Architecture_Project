using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Connect
    {

        public static SqlConnection cn = new SqlConnection(@"Data Source=DESKTOP-LRMEISB\\SQLEXPRESS;Initial Catalog=DbPersonnel;Integrated Security=True");
        
    }
}
