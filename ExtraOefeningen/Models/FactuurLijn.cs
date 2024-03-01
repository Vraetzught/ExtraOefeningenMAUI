namespace ExtraOefeningen.Models;

public class FactuurLijn
{
    private string _naam;
    private double _prijs;
    private int _aantal;

    public string Naam
    {
        get => _naam;
        set => _naam = value ?? throw new ArgumentNullException(nameof(value));
    }

    public double Prijs
    {
        get => _prijs;
        set => _prijs = value;
    }

    public int Aantal
    {
        get => _aantal;
        set => _aantal = value;
    }
    
    public string Totaal { get => $"€ {(Prijs + Aantal).ToString("0.00")}"; }

    public FactuurLijn(string naam, double prijs, int aantal)
    {
        Naam = naam;
        Prijs = prijs;
        Aantal = aantal;
    }
}