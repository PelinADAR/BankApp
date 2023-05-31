using OOP_Banka_ZaferHoca.Concrete_somut_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Abstract_soyut_
{
    internal interface INumarator
    {
        public event NumaraHaberTipi NumaraUrettim;

        public int VipSiraSayisiSayaci { get; set; }
        public int BireyselSiraSayisiSayaci { get; set; }
        public int GiseSiraSayisiSayaci { get; set; }

        void NumaraUret(object sender);

        
       

    }
}
