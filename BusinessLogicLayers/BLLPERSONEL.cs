using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayers
{
    public class BLLPERSONEL
    {
        public static int Insert(EPERSONEL Item)
        {
            if (Item.ad != null && Item.ad.Trim().Length > 0 && Item.soyad.Trim().Length > 0 && Item.tel != null && Item.ad.Trim().Length > 0 && Item.tel.Trim().Length > 0 && Item.maasId > 0 && Item.bolumId > 0)
            {
                return FPERSONEL.Insert(Item);
            }
            return -1;
        }
        public static bool Update(EPERSONEL Item)
        {
            if (Item.personelId > 0 && Item.ad != null && Item.soyad.Trim().Length > 0 && Item.tel != null && Item.maasId > 0 && Item.bolumId > 0)
            {
                return FPERSONEL.Update(Item);
            }
            return false;
        }

        public static bool Delete(int _personelId)
        {
            if (_personelId > 0)
            {
                return FPERSONEL.Delete(_personelId);
            }
            return false;
        }
        public static List<EPERSONEL> SelectList()
        {
            return FPERSONEL.SelectList();
        }
        public static List<EPERSONEL> SelectList1()
        {
            return FPERSONEL.SelectList1();
        }
    }
}
