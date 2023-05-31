using OOP_Banka_ZaferHoca.Concrete_somut_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Abstract_soyut_
{
    internal interface IKuyruk
    {
        event NumaraHaberTipi NumaraAtadim;
        public List<INumara>  VipNumaraListesi { get; set; }
        public List<INumara> BireyselNumaraListesi { get; set; }
        public List<INumara> GiseNumaraListesi { get; set; }

        public int Sayac { get; set; }

        void NumaratordenNumaraAl(INumara numara);
        void GiseyeNumaraGonder(object sender);


    }
}
