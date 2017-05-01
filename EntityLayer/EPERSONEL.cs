using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EPERSONEL : IDisposable
    {
        public int _personelId;
        public string _ad;
        public string _soyad;
        public string _tel;
      
        public int _maasId;
        public int _bolumId;
        public string bolumAd;

        public string bolumAdi
        {
            get { return bolumAd; }
            set { bolumAd = value; }
        }
        public int personelId
        {
            get { return _personelId; }
            set { _personelId = value; }
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
        public string soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        public int maasId
        {
            get { return _maasId; }
            set { _maasId = value; }
        }
        public int bolumId
        {
            get { return _bolumId; }
            set { _bolumId = value; }
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
