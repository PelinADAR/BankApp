using OOP_Banka_ZaferHoca.Concrete_somut_;
using OOP_Banka_ZaferHoca.Enum;

using static OOP_Banka_ZaferHoca.Concrete_somut_.Banka;

namespace OOP_Banka_ZaferHoca.Abstract_soyut_
{
    internal interface IMusteri
    {
        //event delegateAdi NumaratorBenGeldim
        //event delegateAdi GiseBenGeldim


        //NumaratorBenGeldim ismindeki event HaberTipi isimli delege ile temsil ediliyor.
        event HaberTipi NumaratorBenGeldim;
        event HaberTipi GiseBenGeldim;

        //To Do: GıseBenGeldim eklenecek


        public string TcKimlikNo { get; set; }
        IslemTipi IslemTipi { get; set; }
        public INumara Numara { get; set; }

        void NumaraAl();
        void KontrolEt(INumara numara);
        
    }
}
