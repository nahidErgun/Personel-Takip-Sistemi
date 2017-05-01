using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EYONETICI : IDisposable
    {
        public int _yoneticiId;
        public string _ad;
        public string _soyad;
        public string _tel;
        public string _adres;

        public int yoneticiId
        {
            get { return _yoneticiId; }
            set { _yoneticiId = value; }
        }
        public string ad
        {
            get { return _ad; }
            set { _ad = value; }
        }
        public string soyad
        {
            get { return _soyad; }
            set { _soyad = value; }
        }
        public string tel
        {
            get { return _tel; }
            set { _tel = value; }
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        public string adres
        {
            get { return _adres; }
            set { _adres = value; }
        }
    }
}
