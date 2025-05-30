using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    class AracParkYerleri
    {
        public int ID { get; set; }
        public string ParkYerleri { get; set; }
        public string Durumu { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileri { get; set; }
    }
}
