using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using FacadeLayer;

namespace BusinessLogicLayers
{
    public class BLLVERGI
    {
        public static bool Update(EVERGI Item)
        {
            if (Item.tutar > 0)
            {
                return FVERGI.Update(Item);
            }
            return false;
        }

        public static List<EVERGI> SelectList()
        {
            return FVERGI.SelectList();
        }
    }
}
