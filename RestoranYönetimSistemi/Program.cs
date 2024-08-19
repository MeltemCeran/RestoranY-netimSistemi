namespace RestoranYönetimSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");

            Yiyecek yiyecek = new Yiyecek("Kek" , "xyz Toptan Gıda" , 170.50 , 10);

            yiyecek.GetInfo();

            yiyecek.UrunuDosyayaYaz();

            İçecek icecek = new İçecek("Meyve Suyu", "abc Meyveleri", 40, 50);

            icecek.GetInfo();

            icecek.UrunuDosyayaYaz();

            SarfMalzeme sarfMalzeme = new SarfMalzeme("Paspas", "klm Temizlik", 99, 2);

            sarfMalzeme.GetInfo();

            sarfMalzeme.UrunuDosyayaYaz();

            Yiyecek yiyecek1 = new Yiyecek("Köfte", "abc Kasap", 50.70, 60);

            yiyecek1.UrunuDosyayaYaz();

            İçecek icecek1 = new İçecek("Gazoz", "kk içecek", 40, 100);

            icecek1.UrunuDosyayaYaz();

            SarfMalzeme sarfMalzeme1 = new SarfMalzeme("Temizlik bezi", "klm Temizlik", 25, 20);

            sarfMalzeme1.UrunuDosyayaYaz();


        }
    }

}
