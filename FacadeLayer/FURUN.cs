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
    public class FURUN
    {

        public static int Insert(EURUN Item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("insertUrun", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ad", Item.ad);
                com.Parameters.AddWithValue("bedel", Item.bedel);
                
                etkilenen = com.ExecuteNonQuery();

                com.Connection.Close();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }





        public static bool Update(EURUN Item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("updateUrun", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("urunId", Item.urunId);
                /*com.Parameters.AddWithValue("ad", Item.ad);*/
                com.Parameters.AddWithValue("bedel", Item.bedel);
                /*com.Parameters.AddWithValue("sirketId", Item.sirketId);*/
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static bool Delete(int _urunId)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("deleteUrun", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("urunId", _urunId);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static List<EURUN> SelectList1()
        {
            List<EURUN> itemList = null;

            try
            {
                SqlCommand com = new SqlCommand("adagoreurunlistele", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EURUN>();

                    while (rdr.Read())
                    {
                        EURUN item = new EURUN();
                        item.urunId = Convert.ToInt32(rdr[0]);
                        item.ad = rdr[1].ToString();
                        item.bedel = Convert.ToDecimal(rdr[2]);

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

        public static List<EURUN> SelectList2()
        {
            List<EURUN> itemList = null;

            try
            {
                SqlCommand com = new SqlCommand("urunlerinadinilistele", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EURUN>();

                    while (rdr.Read())
                    {
                        EURUN item = new EURUN();
                        item.urunId = Convert.ToInt32(rdr[0]);
                        item.ad = rdr[1].ToString();
                        item.bedel = Convert.ToDecimal(rdr[2]);

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

        public static List<EURUN> SelectList()
        {
            List<EURUN> itemList = null;
            try
            {
                SqlCommand com = new SqlCommand("urunfiyatagorelistele", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EURUN>();
                    while (rdr.Read())
                    {
                        EURUN item = new EURUN();


                        item.urunId = Convert.ToInt32(rdr[0]);
                        item.ad = rdr[1].ToString();
                        item.bedel = Convert.ToDecimal(rdr[2]);
                        /*item.sirketId = Convert.ToInt32(rdr["sirketId"]);*/
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
