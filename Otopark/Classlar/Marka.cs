using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otopark.Classlar
{
    class Marka
    {
        public int ID { get; set; }
        public string MarkaAdı { get; set; }
        public virtual ICollection<Seri> seri { get; set; }
        public virtual ICollection<AracParkBilgileri> AracParkBilgileri { get; set; }
    }
}
