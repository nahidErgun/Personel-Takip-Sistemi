using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EBOLUM : IDisposable
    {
        public int _bolumId;
        public string _ad;
        public int _sirketId;
       

        public int bolumId
        {
            get { return _bolumId; }
            set { _bolumId = value; }
        }
        public string ad
        {
            get { return _ad; }
            set { _ad = value; }
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

