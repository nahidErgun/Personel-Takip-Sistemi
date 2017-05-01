using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EURUN : IDisposable
    {
        public int _urunId;
        public string _ad;
        public decimal _bedel;
        public int _sirketId;

        public int urunId
        {
            get { return _urunId; }
            set { _urunId = value; }
        }
        public string ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public decimal bedel
        {
            get { return _bedel; }
            set { _bedel = value; }
        }
        public int sirketId
        {
            get { return _sirketId; }
            set { _sirketId = value; }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
