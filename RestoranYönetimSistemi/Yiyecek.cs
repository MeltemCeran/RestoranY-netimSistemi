
namespace RestoranYönetimSistemi
{
    public class Yiyecek : Urun, ISogukDepo, IDosyalama
    {
        public Yiyecek(string urunAdi, string tedarikci, double fiyat, int stok) : base(urunAdi, tedarikci, fiyat, stok)
        {
        }

        public DateTime SonKullanmaTarihi { get ; set ; }

        public override void StokKontrol()
        {
            Console.WriteLine($"Stokta kalan {Stok} adet");
        }

        public void UrunuDosyayaYaz()
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("yiyecek.txt", true))
                {
                    sw.WriteLine($"Adı: {UrunAdi} , Tedarikçi: {Tedarikci} ,  Fiyat: {Fiyat} , Stok Durumu: {Stok}");
                }
                Console.WriteLine($"{UrunAdi} dosyaya yazıldı.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Dosyaya yazma sırasında hata oluştu: " + ex.Message);
            }
        }
    }

}
