using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EMAAS : IDisposable
    {
        public int _maasId;
        public decimal _miktar;

        public int maasId
        {
            get { return _maasId; }
            set { _maasId = value; }
        }
        public decimal miktar
        {
            get { return _miktar; }
            set { _miktar = value; }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }

}
