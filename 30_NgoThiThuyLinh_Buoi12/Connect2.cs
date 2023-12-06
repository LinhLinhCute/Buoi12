using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace _30_NgoThiThuyLinh_Buoi12
{
    class Connect2
    {
        public SqlConnection connect;
        public Connect2()
        {
            connect = new SqlConnection("Data Source =A209PC18; Initial Catalog= QLHN; Integrated Security = true");
        }
        public Connect2(string strcn)
        {
            connect = new SqlConnection(strcn);
        }
    }
}
