using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    class Satis
    {
        public int ID { get; set; }
        public int SatisID { get; set; }
        public int MusteriID { get; set; }
        public string AdSoyad { get; set; }
        public string Telefon { get; set; }
        public string Plaka { get; set; }
        public int SeriID { get; set; }
        public int MarkaID { get; set; }
        public string Yil { get; set; }
        public DateTime GirisTarihi { get; set; }
        public DateTime CikisTarihi { get; set; }
        public string Aciklama { get; set; }
        public decimal SaatUcretı { get; set; }
        public decimal Tutar { get; set; }
        public decimal Sure { get; set; }
        public string Renk { get; set; }
        public int ParkYeriID { get; set; }


    }
}
