using System;
using System.Collections.Generic;

public class Produkt
{
    public string Nazwa { get; set; }
    public decimal Cena { get; set; }
    public int Ilość { get; set; }

    public Produkt(string nazwa, decimal cena, int ilość)
    {
        Nazwa = nazwa;
        Cena = cena;
        Ilość = ilość;
    }

    public override string ToString()
    {
        return $"Nazwa: {Nazwa}, Cena: {Cena}, Ilość: {Ilość}";
    }

    public static bool operator ==(Produkt a, Produkt b)
    {
        if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
            return true;
        if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
            return false;
        return a.Cena == b.Cena;
    }

    public static bool operator !=(Produkt a, Produkt b)
    {
        return !(a == b);
    }

    public static bool operator <(Produkt a, Produkt b)
    {
        return a.Cena < b.Cena;
    }

    public static bool operator >(Produkt a, Produkt b)
    {
        return a.Cena > b.Cena;
    }

    public static Produkt operator ++(Produkt a)
    {
        a.Ilość++;
        return a;
    }

    public static Produkt operator --(Produkt a)
    {
        a.Ilość--;
        return a;
    }


}


