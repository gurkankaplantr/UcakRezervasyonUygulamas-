namespace UcakRezervasyon.Models
{
    public partial class Lokasyon
    {
        public int LoksayonId { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        public string Havaalani { get; set; }

        public struct Ucus(string ulke, string sehir, string havaalani)
        {
            public string Ulke { get; set; } = ulke;
            public string Sehir { get; set; } = sehir;
            public string Havaalani { get; set;} = havaalani;
        }

        public List<Ucus> ucuslar = new List<Ucus>
        {
            new Ucus("", "", ""),
            new Ucus("Türkiye", "Diyarbakır", "Diyarbakır Havalimanı (DIY)"),
            new Ucus("Türkiye", "Elazığ", "Elazığ Havalimanı (EZS)"),
            new Ucus("Türkiye", "Erzincan", "Erzincan Yıldırım Akbulut Havalimanı (ERC)"),
            new Ucus("Türkiye", "Erzurum", "Erzurum Havalimanı (ERZ)"),
            new Ucus("Türkiye", "Eskişehir", "Hasan Polatkan Havalimanı (AOE)"),
            new Ucus("Türkiye", "Gaziantep", "Gaziantep Havalimanı (GZT)"),
            new Ucus("Türkiye", "Hakkari", "Yüksekova Havalimanı (YKO)"),
            new Ucus("Türkiye", "Hatay", "Hatay Havalimanı (HTY)"),
            new Ucus("Türkiye", "Iğdır", "Iğdır Şehit Bülent Aydın Havalimanı (IGD)"),
            new Ucus("Türkiye", "Isparta", "Isparta Süleyman Demirel Havalimanı (ISE)"),
            new Ucus("Türkiye", "İstanbul", "İstanbul Havalimanı (IST)"),
            new Ucus("Türkiye", "İstanbul", "Sabiha Gökçen Havalimanı (SAW)"),
            new Ucus("Türkiye", "İzmir", "İzmir Adnan Menderes Havalimanı (ADB)"),
            new Ucus("Türkiye", "Kahramanmaraş", "Kahramanmaraş Havalimanı (KCM)"),
            new Ucus("Türkiye", "Kars", "Kars Harakani Havalimanı (KSY)"),
            new Ucus("Türkiye", "Kastamonu", "Kastamonu Havalimanı (KFS)"),
            new Ucus("Türkiye", "Kayseri", "Kayseri Havalimanı (ASR)"),
            new Ucus("Türkiye", "Kocaeli", "Kocaeli Cengiz Topel Havalimanı (KCO)"),
            new Ucus("Türkiye", "Konya", "Konya Havalimanı (KYA)"),
            new Ucus("Türkiye", "Kütahya", "Zafer Bölgesel Havalimanı (KZR)"),
            new Ucus("Türkiye", "Malatya", "Malatya Havalimanı (MLX)"),
            new Ucus("Türkiye", "Mardin", "Mardin Prof. Dr. Aziz Sancar Havalimanı (MQM)"),
            new Ucus("Türkiye", "Muğla-Bodrum", "Milas-Bodrum Havalimanı (BJV)"),
            new Ucus("Türkiye", "Muğla-Dalaman", "Dalaman Havalimanı (DLM)"),
            new Ucus("Türkiye", "Muş", "Muş Havalimanı (MSR)"),

        };
    }
}
