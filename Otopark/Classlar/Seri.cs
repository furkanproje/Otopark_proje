using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    class Seri
    {
        public int MarkaID { get; set; }
        public int ID { get; set; }
        public string seri { get; set; }
        public virtual Marka Marka { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileri { get; set; }
    }
}
