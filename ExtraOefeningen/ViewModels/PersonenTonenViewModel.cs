using System.Collections.ObjectModel;

namespace ExtraOefeningen.ViewModels;

[QueryProperty(nameof(Personen), "Personen")]

public partial class PersonenTonenViewModel : BaseViewModel
{
    [ObservableProperty ] ObservableCollection<Persoon> personen;
    [ObservableProperty] private double averageAge;

    partial void OnPersonenChanged(ObservableCollection<Persoon> value)
    {
        AverageAge = 0;
        
        foreach (Persoon persoon in value)
        {
            TimeSpan verschil = DateTime.Now - persoon.Geboortedatum;
            int leeftijd = verschil.Days / 365;
            AverageAge += leeftijd;
        }

        averageAge /= value.Count;
    }
}