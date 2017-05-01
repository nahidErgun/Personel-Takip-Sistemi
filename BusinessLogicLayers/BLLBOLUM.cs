using EntityLayer;
using FacadeLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayers
{
    public class BLLBOLUM
    {
        public static int Insert(EBOLUM Item)
        {
            if (Item.ad != null && Item.ad.Trim().Length > 0)
            {
                return FBOLUM.Insert(Item);
            }
            return -1;
        }

        public static List<EBOLUM> SelectList()
        {
            return FBOLUM.SelectList();
        }
    }
}
