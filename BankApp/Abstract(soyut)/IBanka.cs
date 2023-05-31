using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Abstract_soyut_
{
    internal interface IBanka
    {
        public List<IGise> Giseler { get; set; }
        public INumarator Numarator { get; set; }
        //public List<IMusteri> Musteriler { get; set; }
        public IKuyruk Kuyruk { get; set; }
        public ISayac Sayac { get; set; }

        void MesaiBaslat(int giseSayisi);
        void MesaiBitir();




    }
}
