using System.Collections;

namespace MusteriKontrol
{
    public class Musteri
    {
        #region Sanal Database
        static ArrayList musteriDatabase;
        #endregion

        #region Static Yapıcı Metot
        static Musteri()
        {
            musteriDatabase = new ArrayList();
        }
        #endregion

        #region Field
        public int musteriId { get; set; }
        public string Isim { get; set; }
        public string soyisim { get; set; }
        public string emailAdres { get; set; }
        public string sifre { get; set; }
        #endregion
        #region Kapsulleme 
        private string _kullaniciAdi;
        public string kullaniciAdi
        {
            get { return this._kullaniciAdi; }

            set
            {
                bool kullaniciAdiKontrol = musteriKullanicAdiKontrol(value);
                if (kullaniciAdiKontrol)
                {
                    Console.WriteLine("Eklemek istediğiniz kullanıcı adı sistem içerisinde kayıtlı");
                    this._kullaniciAdi = string.Empty;

                }
                else
                {
                    this._kullaniciAdi = value;
                }

            }

        }
        #endregion
        #region Static Metodlar
        static bool musteriKullanicAdiKontrol(string _kullaniciadi)
        {
            bool Kontrol = false;
            for (int i = 0; i < musteriDatabase.Count; i++)
            {
                Musteri Temp = (Musteri)musteriDatabase[i];
                if (Temp.kullaniciAdi == _kullaniciadi)
                {

                    Kontrol = true;
                    break;
                }
            }
            return Kontrol;
        }
        #endregion
        public static void MusteriEkle(Musteri M)
        {
            #region Parametre Kontrol 
            if (M != null && !string.IsNullOrEmpty(M.kullaniciAdi) && !string.IsNullOrEmpty(M.emailAdres))
            {
                bool emailAdresKontrol = musteriKullanicAdiKontrol(M.emailAdres);
                if (emailAdresKontrol)
                {
                    Console.WriteLine("eklemek istediğiniz kullanıcı sistemde kayıtlı ");
                }
                else
                {
                    musteriDatabase.Add(M);
                    Console.WriteLine("yeni kayıt islemi basarılı");

                }
            }
            #endregion
        }

    }
}
