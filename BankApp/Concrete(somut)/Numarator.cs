using OOP_Banka_ZaferHoca.Abstract_soyut_;
using OOP_Banka_ZaferHoca.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Concrete_somut_
{
    internal class Numarator : INumarator
    {
        public Numarator()
        {
            BireyselSiraSayisiSayaci = 1000;
            GiseSiraSayisiSayaci = 2000;
            VipSiraSayisiSayaci = 3000;
        }

        int _bireyselSayac;
        int _giseSayac;
        int _vipSayac;

        public int BireyselSiraSayisiSayaci
        {
            get { return _bireyselSayac; }
            set
            {
                if (value > 999 && value < 2000)
                    _bireyselSayac = value;
            }
        }
      
        public int GiseSiraSayisiSayaci
        {
            get { return _bireyselSayac; }
            set
            {
                if (value > 1999 && value < 3000)
                    _bireyselSayac = value;
            }
        }

        public int VipSiraSayisiSayaci
        {
            get { return _bireyselSayac; }
            set
            {
                if (value > 2999 && value < 4000)
                    _bireyselSayac = value;
            }
        }


        public event NumaraHaberTipi NumaraUrettim;

        public void NumaraUret(object sender)
        {
            IMusteri musteri=sender as IMusteri;       // IMusteri musteri=(IMusteri)sender;
           

            INumara numara=null;

            if(musteri.IslemTipi==IslemTipi.Bireysel)
            {
                numara=new BireyselNumarasi();
                numara.SiraNumarasi = BireyselSiraSayisiSayaci;
                BireyselSiraSayisiSayaci++;
            }
            else if(musteri.IslemTipi==IslemTipi.Gise)
            {
                numara = new GiseNumarasi();
                numara.SiraNumarasi = GiseSiraSayisiSayaci;
                GiseSiraSayisiSayaci++;
            }
            //to do: Vip eklenecek

            musteri.Numara = numara;
            NumaraUrettim(numara);









        }
    }
}
