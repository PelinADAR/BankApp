using OOP_Banka_ZaferHoca.Abstract_soyut_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Concrete_somut_
{
    internal class Gise : IGise
    {
        public INumara IslemYapilanNumara { get ; set; }

        public event HaberTipi KuyrukBenMusaitim;
        public event NumaraHaberTipi SayacIsımBitti;

        public void Kontrol(object sender)
        {
            IMusteri musteri = (IMusteri)sender;
            if (musteri.Numara == IslemYapilanNumara)
                Islem();
        }

        public void Islem()
        {
            SayacIsımBitti(IslemYapilanNumara);        //sayaca ısım bitti diyor.
            KuyrukBenMusaitim(this);                   //gıse kuyruğa ben müsaitim diyor               
        }

       

       
    }
}
