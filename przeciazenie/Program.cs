class Program
{
    public static Produkt Produkt2 { get; private set; }
    public static Produkt Produkt3 { get; private set; }
    public static Produkt Produkt1 { get; private set; }

    static void Main(string[] args)
    {
        var magazyn = new Magazyn("Magazyn1");


        Produkt1 = new Produkt("Bluza", 210, 15);
        Produkt2 = new Produkt("Spodnie", 100, 20);
        Produkt3 = new Produkt("Fifa", 300, 30);


        magazyn.DodajProdukt(Produkt1);
        magazyn.DodajProdukt(Produkt2);
        magazyn.DodajProdukt(Produkt3);

        magazyn.WyświetlProdukty();

        magazyn.SortujProdukty();

        magazyn.WyświetlProdukty();
        Console.ReadLine();
    }

    public void SortujProdukty()
    {
        
        


        if (Produkt1 == Produkt2)
            Console.WriteLine("");
        else
            Console.WriteLine("");


    }
}

