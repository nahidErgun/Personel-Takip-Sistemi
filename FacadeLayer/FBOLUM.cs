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
    public class FBOLUM
    {


        public static int Insert(EBOLUM Item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("insertBolum", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ad", Item.ad);
                etkilenen = com.ExecuteNonQuery();

                com.Connection.Close();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }


        public static List<EBOLUM> SelectList()
        {
            List<EBOLUM> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("bölümlerilisteleme", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EBOLUM>();
                    while (rdr.Read())
                    {
                        EBOLUM item = new EBOLUM();

                        item.bolumId = Convert.ToInt32(rdr["bolumId"]);
                        item.ad = rdr["ad"].ToString();
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
