using OOP_Banka_ZaferHoca.Abstract_soyut_;



//Conrete : Somut
namespace OOP_Banka_ZaferHoca.Concrete_somut_

{

    //public delegate void EventHandler(object? sender,EventArgs e);

    //HaberTipi ismindeki delege obje türünde bir parametre alacak

    public delegate void HaberTipi(object sender);                         
    public delegate void NumaraHaberTipi(INumara param);      
    

    /*
      1- Delege tanımlar public delegate void HaberTipi(object sender);
      2- Event tanımlanır.public event HaberTipi NumaratorBenGeldim;
      3- Event'i Metoda bağlıyoruz.
      musteri.NumaratorBenGeldim += banka.Numarator.NumaraUret;
      4- NumaraUret(object sender){} metodu tanımlandı.
      5- NumaratorBenGeldim(this);
     */
     

    internal class Banka : IBanka
    {
        public Banka()
        {
            Giseler = new List<IGise>();
        }

        public List<IGise> Giseler { get ; set ; }
        public INumarator Numarator { get; set; }
        public IKuyruk Kuyruk { get; set; }
        public ISayac Sayac { get; set; }



        //Banka yeni açıldı gün içindeki kuralları bunlar diyebiliriz.

        public void MesaiBaslat(int giseSayisi)
        {
             Kuyruk  = new Kuyruk();

            Sayac = new Sayac();

            Numarator= new Numarator();

            for(int i=0; i<giseSayisi; i++)
            {
                IGise gise = new Gise();
                gise.KuyrukBenMusaitim += Kuyruk.GiseyeNumaraGonder;            //gişe KuyrukBenMüsaitim Event'i çağırıldığında Kuyruk üzerindeki GişeyenumaraGönder metohdu çalıştırılacak.

                //gise.SayacIsımBitti += Sayac.GisedenIsiBitenNumaraAl;

                Giseler.Add(gise);
            }

            Numarator.NumaraUrettim += Kuyruk.NumaratordenNumaraAl;

        }
       
        public void MesaiBitir()
        {
            
        }
    }
}
