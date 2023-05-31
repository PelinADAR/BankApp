using OOP_Banka_ZaferHoca.Abstract_soyut_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Concrete_somut_
{
    internal class Kuyruk : IKuyruk
    {
        public Kuyruk()
        {
            VipNumaraListesi = new List<INumara>();
            BireyselNumaraListesi = new List<INumara>();
            GiseNumaraListesi = new List<INumara>();
        }


        public List<INumara> VipNumaraListesi { get ; set; }
        public List<INumara> BireyselNumaraListesi { get; set; }
        public List<INumara> GiseNumaraListesi { get; set; }
        public int Sayac { get; set; }


        public event NumaraHaberTipi NumaraAtadim;


        //gise.KuyrukBenMusaitim += Kuyruk.GiseyeNumaraGonder; denildiğinde alltaki metot çalışıyor.
        //Gise nesnesinin islem() metodu çalıştırıldığında KuyrukBenmusaitim eventi çağırılıyor.
        public void GiseyeNumaraGonder(object sender)
        {
            IGise gise = sender as Gise;

            if(VipNumaraListesi.Count>0)
            {
                gise.IslemYapilanNumara=VipNumaraListesi[0];
                VipNumaraListesi.RemoveAt(0);
            }
            else if(Sayac<3 && GiseNumaraListesi.Count>0 || BireyselNumaraListesi.Count==0)
            {
                gise.IslemYapilanNumara = GiseNumaraListesi[0];
                GiseNumaraListesi.RemoveAt(0);
                Sayac++;
            }
            else if(BireyselNumaraListesi.Count>0)
            {
                gise.IslemYapilanNumara = BireyselNumaraListesi[0];
                BireyselNumaraListesi.RemoveAt(0);
                Sayac=0;
            }

            NumaraAtadim(gise.IslemYapilanNumara);


        }

        

        public void NumaratordenNumaraAl(INumara numara)
        {
            if (numara is BireyselNumarasi)
                BireyselNumaraListesi.Add(numara);
            else if (numara is GiseNumarasi)
                GiseNumaraListesi.Add(numara);
            else if (numara is VipNumarasi)
                VipNumaraListesi.Add(numara);
        }


       
    }
}
