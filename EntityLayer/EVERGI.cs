using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EVERGI : IDisposable
    {
        public int _vergiNo;
        public decimal _tutar;

        public int vergiNo
        {
            get { return _vergiNo; }
            set { _vergiNo = value; }
        }
        public decimal tutar
        {
            get { return _tutar; }
            set { _tutar = value; }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
