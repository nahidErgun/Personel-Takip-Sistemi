using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadeLayer
{
    class Baglanti
    {
        public static readonly SqlConnection Con = new SqlConnection("Data Source=nahide\\SQLEXPRESS;Initial Catalog=personeltakip;Integrated Security=True");
    }
}
