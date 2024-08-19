namespace RestoranYönetimSistemi
{
    public abstract class Urun
    {
        protected Urun(string urunAdi, string tedarikci, double fiyat, int stok)
        {
            UrunAdi = urunAdi;
            Tedarikci = tedarikci;
            Fiyat = fiyat;
            Stok = stok;
        }

        public string UrunAdi { get; set; }

        public string Tedarikci { get; set; }

        public double Fiyat { get; set; }

        public int Stok { get; set; }


        public void GetInfo()
        {
            Console.WriteLine($"Adı: {UrunAdi} \n");
            Console.WriteLine($"Tedarikçi: {Tedarikci} \n");
            Console.WriteLine($"Fiyat: {Fiyat}  \n");
            Console.WriteLine($"Stok: {Stok}  \n");
            Console.WriteLine("---------");

        }

        public abstract void StokKontrol();

    }

}
