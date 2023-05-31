using OOP_Banka_ZaferHoca.Concrete_somut_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Banka_ZaferHoca.Abstract_soyut_
{
    internal interface IGise
    {
        //Class Members -sınıf üyeleri
        /*fields
         * properties
         * Methods
         * Constructor method
         * const
         * events 
         */

        //event Delegeİsmi eventİsmi

        event HaberTipi KuyrukBenMusaitim;
        event NumaraHaberTipi SayacIsımBitti;

        //To do: numara

        INumara IslemYapilanNumara { get; set; }
        void Islem();

        void Kontrol(object sender);
    }
}
