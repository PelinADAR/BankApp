using OOP_Banka_ZaferHoca.Abstract_soyut_;
using OOP_Banka_ZaferHoca.Concrete_somut_;
using OOP_Banka_ZaferHoca.Enum;

namespace OOP_Banka_ZaferHoca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cmbIslemTipi.Items.Add(IslemTipi.Bireysel);
            cmbIslemTipi.Items.Add(IslemTipi.Gise);
        }

        static IBanka banka;
        private void button1_Click(object sender, EventArgs e)
        {
            banka = new Banka();
            banka.MesaiBaslat(3);

        }

        private void btnMusteriGeldi_Click(object sender, EventArgs e)
        {
            //string metin=new string('*',30);
            //DateTime date=new DateTime();

            // Ç O O O O K     Ö N E M L Ý !!!!

            IMusteri musteri=new Musteri();                                  //Musteri class'ýndan yeni bir instance alýyoruz ve Imusteri veri tipindeki musteri deðiþkeninde tutuyoruz.  
            musteri.IslemTipi = (IslemTipi)cmbIslemTipi.SelectedItem;
            musteri.TcKimlikNo = txtTcNo.Text;

            musteri.NumaratorBenGeldim += banka.Numarator.NumaraUret;               //Müþterinin NumaratörBenGeldim Event'i tetiklendiðinde NumaraUret metodu çalýþsýn.

            foreach(IGise gise in banka.Giseler)
            {
                musteri.GiseBenGeldim += gise.Kontrol;
            }


            musteri.NumaraAl();


            banka.Kuyruk.NumaraAtadim += musteri.KontrolEt;


            banka.Numarator.NumaraUrettim += banka.Kuyruk.NumaratordenNumaraAl;


        }

        
    }
}