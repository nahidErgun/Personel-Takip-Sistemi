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
    public class FBUTCE
    {
        public static bool Update(EBUTCE Item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("updateButce", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                
                com.Parameters.AddWithValue("gelir", Item.gelir);
                com.Parameters.AddWithValue("gider", Item.gider);
               /* com.Parameters.AddWithValue("total", Item.total);*/
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }



        public static List<EBUTCE> SelectList()
        {
            List<EBUTCE> itemList = null;

            try
            {
                SqlCommand com = new SqlCommand("listbutce", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EBUTCE>();

                    while (rdr.Read())
                    {
                        EBUTCE item = new EBUTCE();

                        item.gelir = Convert.ToDecimal(rdr["gelir"]);
                        item.gider = Convert.ToDecimal(rdr["gider"]);
                        item.total = Convert.ToDecimal(rdr["total"]);
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
