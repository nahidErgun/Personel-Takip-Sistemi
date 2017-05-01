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
    public class FMAAS
    {


        public static int Insert(EMAAS Item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("InsertMaas", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("miktar", Item.miktar);
                etkilenen = com.ExecuteNonQuery();

                com.Connection.Close();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }


        public static bool Update(EMAAS Item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("updateMaas", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("maasId", Item.maasId);
                com.Parameters.AddWithValue("miktar", Item.miktar);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static List<EMAAS> SelectList()
        {
            List<EMAAS> itemList = null;

            try
            {
                SqlCommand com = new SqlCommand("listmaas", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EMAAS>();

                    while (rdr.Read())
                    {
                        EMAAS item = new EMAAS();

                        item.maasId = Convert.ToInt32(rdr["maasId"]);
                        item.miktar = Convert.ToInt32(rdr["miktar"]);
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
