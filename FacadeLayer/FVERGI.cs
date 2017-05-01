using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;

namespace FacadeLayer
{
    public class FVERGI
    {
        public static bool Update(EVERGI Item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("vergiguncelle", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("tutar", Item.tutar);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static List<EVERGI> SelectList()
        {
            List<EVERGI> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("vergigor", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EVERGI>();
                    while (rdr.Read())
                    {
                        EVERGI item = new EVERGI();


                        item.vergiNo = Convert.ToInt32(rdr["vergiNo"]);
                        item.tutar = Convert.ToDecimal(rdr["tutar"]);
                        itemList.Add(item);
                    }
                }
                rdr.Close();
                com.Connection.Close();
            }
            catch
            {
                itemList = null;
            }
            return itemList;
        }
    }
}
