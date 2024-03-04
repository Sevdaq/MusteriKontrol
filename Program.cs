namespace MusteriKontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Musteri M1 = new Musteri();
            M1.musteriId = 1;
            M1.Isim = "Cengiz";
            M1.soyisim = "atilla";
            M1.emailAdres = "cengizatilla@hotmail.com";
            M1.kullaniciAdi = "cengiz.atilla";
            M1.sifre = "1";
            Musteri.MusteriEkle(M1);

            Musteri M2 = new Musteri();
            {
                M1.musteriId = 1;
                M1.Isim = "Cengiz";
                M1.soyisim = "atilla";
                M1.emailAdres = "cengizatilla@hotmail.com";
                M1.kullaniciAdi = "cengiz.atilla";
                M1.sifre = "2";
                Musteri.MusteriEkle(M2);
            }







        }
    }

}
