using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadeLayer;
using EntityLayer;


namespace BusinessLogicLayers
{
    public class BLLLOGIN
    {
        public static bool Login(int personelId, int bolumId)
        {
            if (personelId > 0 && bolumId > 0)
            {
                return FLOGIN.Login(personelId, bolumId);
            }
            //Else send a warning code to BusinessLogicLayer
            return false;
        }
    }
}
