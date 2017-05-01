using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EBUTCE : IDisposable
    {
        public int _butceId;
        public decimal _gelir;
        public decimal _gider;
        public decimal _total;
        
        public int _sirketId;
        public int _vergino;

        public int butceId
        {
            get { return _butceId; }
            set { _butceId = value; }
        }

        public decimal gelir
        {
            get { return _gelir; }
            set { _gelir = value; }
        }

        public decimal gider
        {
            get { return _gider; }
            set { _gider = value; }
        }
        public decimal total
        {
            get { return _total; }
            set { _total = value; }
        }
        public int sirketId
        {
            get { return _sirketId; }
            set { _sirketId = value; }
        }
        public int vergino
        {
            get { return _vergino; }
            set { _vergino = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
