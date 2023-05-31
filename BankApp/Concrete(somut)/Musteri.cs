using OOP_Banka_ZaferHoca.Abstract_soyut_;
using OOP_Banka_ZaferHoca.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Concrete_somut_
{
    internal class Musteri : IMusteri
    {
        public string TcKimlikNo { get ; set ; }
        public IslemTipi IslemTipi { get ; set ; }
        public INumara Numara { get ; set ; }

        public event HaberTipi NumaratorBenGeldim;
        public event HaberTipi GiseBenGeldim;

        public void KontrolEt(INumara numara)
        {
            if(numara==Numara)
                GiseBenGeldim(this);                 //this yazarak musterinin yukardak özelliklerini giseye sunmuş oluyoruz.
        }

        public void NumaraAl()
        {
            if (TcKimlikNo != null)
                NumaratorBenGeldim(this);           //this yazarak musterinin yukardaki özelliklerini numaratöre sunmuş oluyoruz.
        }
    }
}
