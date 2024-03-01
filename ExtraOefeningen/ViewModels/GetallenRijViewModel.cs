using System.Collections.ObjectModel;

namespace ExtraOefeningen.ViewModels;

public partial class GetallenRijViewModel: BaseViewModel
{
    [ObservableProperty] int getal;
    [ObservableProperty] int kleinste;
    [ObservableProperty] int grootste;
    [ObservableProperty] ObservableCollection<int> rij;

    public GetallenRijViewModel()
    {
        Title = "Getallenrij";
        RijLeegmaken();
    }

    [RelayCommand]
    private void GetalToevoegen()
    {
        Rij.Add(Getal);
        Kleinste = Rij.Min();
        Grootste = Rij.Max();
    }

    [RelayCommand]
    private void RijLeegmaken()
    {
        Getal = 0;
        Grootste = 0;
        Kleinste = 0;
        Rij = [];
    }
}
