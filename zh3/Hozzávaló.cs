using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zh3
{
    public class Hozzávaló
    {
        public int RecetID { get; set; }
        public int? FogasID { get; set; } 
        public string NyersanyagNev { get; set; }  
        public double? Mennyiseg_4fo { get; set; } 
        public string EgysegNev { get; set; }
        public double Ár { get; set; }
    }
}
