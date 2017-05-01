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
    public class FPERSONEL
    {
        public static int Insert(EPERSONEL Item)
        {
            int etkilenen = 0;
            try
            {
                SqlCommand com = new SqlCommand("insertPersonel", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("ad", Item.ad);
                com.Parameters.AddWithValue("soyad", Item.soyad);
                com.Parameters.AddWithValue("tel", Item.tel);
                com.Parameters.AddWithValue("maasId", Item.maasId);
                com.Parameters.AddWithValue("bolumId", Item.bolumId);
                etkilenen = com.ExecuteNonQuery();

                com.Connection.Close();
            }
            catch
            {
                etkilenen = -1;
            }
            return etkilenen;
        }
        public static bool Update(EPERSONEL Item)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("personelUpdate", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("personelId", Item.personelId);
                com.Parameters.AddWithValue("ad", Item.ad);
                com.Parameters.AddWithValue("soyad", Item.soyad);
                com.Parameters.AddWithValue("tel", Item.tel);
                com.Parameters.AddWithValue("maasId", Item.maasId);
                com.Parameters.AddWithValue("bolumId", Item.bolumId);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static bool Delete(int _personelId)
        {
            bool sonuc = false;
            try
            {
                SqlCommand com = new SqlCommand("deletePersonel", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                com.Parameters.AddWithValue("personelId", _personelId);
                sonuc = com.ExecuteNonQuery() > 0;
                com.Connection.Close();
            }
            catch
            {
                sonuc = false;
            }
            return sonuc;
        }

        public static List<EPERSONEL> SelectList()
        {
            List<EPERSONEL> itemList = null;

            
            
            try
            {
                SqlCommand com = new SqlCommand("personeladlistele", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EPERSONEL>();
                    
                    
                    while (rdr.Read())
                    {
                        EPERSONEL item = new EPERSONEL();

                       

                        item.personelId =Convert.ToInt32(rdr[0]);
                        item.ad = rdr[1].ToString();
                        item.bolumAdi = rdr[3].ToString();
                        item.soyad = rdr[2].ToString();
                        item.tel = rdr[5].ToString();
                        item.maasId = Convert.ToInt32(rdr[4]);
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
            return itemList ;
        }

        public static List<EPERSONEL> SelectList1()
        {
            List<EPERSONEL> itemList = null;
           
            try
            {
                SqlCommand com = new SqlCommand("orderByBolum", Baglanti.Con);
                com.CommandType = CommandType.StoredProcedure;
                if (com.Connection.State != ConnectionState.Open)
                {
                    com.Connection.Open();
                }
                SqlDataReader rdr = com.ExecuteReader();
                if (rdr.HasRows)
                {
                    itemList = new List<EPERSONEL>();
                    
                    while (rdr.Read())
                    {
                        EPERSONEL item = new EPERSONEL();
                        
                        item.ad = rdr[0].ToString();
                        item.soyad = rdr[1].ToString();
                        item.bolumAdi = rdr[2].ToString();
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
