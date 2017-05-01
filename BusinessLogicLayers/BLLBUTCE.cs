using EntityLayer;
using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayers
{
    public class BLLBUTCE
    {
        public static bool Update(EBUTCE Item)
        {
            if (Item.gelir > 0 && Item.gider > 0)
            {
                return FBUTCE.Update(Item);
            }
            return false;
        }

        public static List<EBUTCE> SelectList()
        {
            return FBUTCE.SelectList();
        }
    }
}
