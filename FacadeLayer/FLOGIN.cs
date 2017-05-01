using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace FacadeLayer
{
    public class FLOGIN
    {
        public static bool Login(int personelId, int bolumId)
        {
            var result = 0;
            try
            {
                SqlCommand com = new SqlCommand("login", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                    com.Connection.Open();
                SqlParameter retval = com.Parameters.Add("@b", SqlDbType.Int);
                retval.Direction = ParameterDirection.ReturnValue;
                com.Parameters.AddWithValue("personelId", personelId);
                com.Parameters.AddWithValue("bolumId", bolumId);
                
                com.ExecuteNonQuery();
                com.Connection.Close();
                result = Convert.ToInt32(com.Parameters["@b"].Value);
            }
            catch
            {
                result = -1;
            }
            if (result == 1)
                return true;
            return false;
        }
    }
}
