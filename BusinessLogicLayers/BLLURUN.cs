using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacadeLayer;
using EntityLayer;

namespace BusinessLogicLayers
{
    public class BLLURUN
    {
        public static int Insert(EURUN Item)
        {
            if (Item.ad != null && Item.ad.Trim().Length > 0 && Item.bedel > 0)
            {
                return FURUN.Insert(Item);
            }
            return -1;
        }
        public static bool Update(EURUN Item)
        {
            if (Item.bedel > 0)
            {
                return FURUN.Update(Item);
            }
            return false;
        }

        public static bool Delete(int _urunId)
        {
            if (_urunId > 0)
            {
                return FURUN.Delete(_urunId);
            }
            return false;
        }


        public static List<EURUN> SelectList()
        {
            return FURUN.SelectList();
        }

        public static List<EURUN> SelectList1()
        {
            return FURUN.SelectList1();
        }
        public static List<EURUN> SelectList2()
        {
            return FURUN.SelectList1();
        }




    }
}
