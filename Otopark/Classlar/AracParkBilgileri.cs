using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    class AracParkBilgileri
    {
        public int ID { get; set; }
        public int MusteriID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public int MarkaID { get; set; }
        public int SeriID { get; set; }
        public string Plaka { get; set; }
        public string Yİl { get; set; }
        public string Renk { get; set; }
        public int ParkYeriID { get; set; }
        public string Aciklama { get; set; }
        public DateTime GirisTarihi { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual Seri Seri { get; set; }
    }
}
