namespace ExtraOefeningen.ViewModels;

public partial class NaamTonenViewModel: BaseViewModel
{
    [ObservableProperty] string naam;
    [ObservableProperty] int getal;
    [ObservableProperty] string resultaat;

    public NaamTonenViewModel()
    {
        Title = "Naam tonen";
        ResultaatLeegmaken();
    }

    [RelayCommand]
    private void NaamTonen()
    {
        Resultaat = Naam;
        for (int i = 0; i < Getal - 1; i++)
            Resultaat += $", {Naam}";
    }

    [RelayCommand]
    private void ResultaatLeegmaken()
    {
        Naam = "";
        Getal = 0;
        Resultaat = "";
    }
}