
internal class Program
{
    private static void Main(string[] args)
    {
        List<int> sayiList = new List<int>();
        sayiList.Add(3);
        sayiList.Add(7);
        sayiList.Add(18);
        sayiList.Add(13);
        sayiList.Add(34);
        sayiList.Add(72);

        List<string> renkList = new List<string>();
        renkList.Add("Pembe");
        renkList.Add("Yeşil");
        renkList.Add("Mavi");
        renkList.Add("Mor");

        Console.WriteLine(sayiList.Count);
        Console.WriteLine(renkList.Count);

        foreach (var sayi in sayiList)
            Console.WriteLine(sayi);
        foreach (var renk in renkList)
            Console.WriteLine(renk);

        sayiList.ForEach(sayi => Console.WriteLine(sayi));
        renkList.ForEach(renk => Console.WriteLine(renk));

        sayiList.Remove(13);
        renkList.Remove("mor");

        sayiList.RemoveAt(2);
        renkList.RemoveAt(1);

        if (sayiList.Contains(3))
            Console.WriteLine("3 list içerisinde var");

        Console.WriteLine(renkList.BinarySearch("Yeşil"));

        //diziyi list e çevirme

        string[] hayvanlar = { "kedi", "köpek", "yılan" };
        List<string> hayvanList = new List<string>(hayvanlar);

        hayvanList.Clear();


        //listeyi oluşturma
        List<Musteriler> musteriList = new List<Musteriler>();

        //musteri nesne olusturma ve tanımlama
        Musteriler musteri1 = new Musteriler();
        Musteriler musteri2 = new Musteriler();

        musteri1.Isim="Mahmut";
        musteri1.Soyisim="Dagcı";
        musteri1.Puan=1020;

        musteri2.Isim="Murat";
        musteri2.Soyisim="Can";
        musteri2.Puan=2600;

        //tanımlanan müsterileri listeye ekleme
        musteriList.Add(musteri1);
        musteriList.Add(musteri2);

        //tanımlaması anında yapılan yeni musteri
        musteriList.Add(new Musteriler(){
            Isim="Hatice",
            Soyisim="Belen",
            Puan=324
        });

        foreach(var mussteri in musteriList)
        {
            Console.WriteLine("müşteri adı:" +mussteri.Isim );
            Console.WriteLine("müşteri soyadı:"+mussteri.Soyisim);
            Console.WriteLine("müşteri puanı:"+ mussteri.Puan);
        }
            

    }
}

public class Musteriler
{
    string isim;
    string soyisim;
    int puan;

    public string Isim { get => isim; set => isim = value; }
    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int Puan { get => puan; set => puan = value; }
}