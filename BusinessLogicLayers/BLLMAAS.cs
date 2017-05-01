using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using EntityLayer;

namespace BusinessLogicLayers
{
    public class BLLMAAS
    {
        public static int Insert(EMAAS Item)
        {
            if (Item.miktar > 0)
            {
                return FMAAS.Insert(Item);
            }
            return -1;
        }
        public static bool Update(EMAAS Item)
        {
            if (Item.miktar > 0 && Item.maasId > 0)
            {
                return FMAAS.Update(Item);
            }
            return false;
        }
        public static List<EMAAS> SelectList()
        {
            return FMAAS.SelectList();
        }

    }
}
