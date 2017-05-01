using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class ESIRKET : IDisposable
    {
        public int _sirketId;
        public string _ad;
        public string _tel;
        public string _adres;
        public int _yoneticiId;
        public int _butceId;
        public int _vergiNo;

        public int sirketId
        {
            get { return _sirketId; }
            set { _sirketId = value; }
        }

        public string ad
        {
            get { return _ad; }
            set { _ad = value; }
        }

        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        public string adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
        public int yoneticiId
        {
            get { return _yoneticiId; }
            set { _yoneticiId = value; }
        }
        public int butceId
        {
            get { return _butceId; }
            set { _butceId = value; }
        }
        public int vergiNo
        {
            get { return _vergiNo; }
            set { _vergiNo = value; }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
