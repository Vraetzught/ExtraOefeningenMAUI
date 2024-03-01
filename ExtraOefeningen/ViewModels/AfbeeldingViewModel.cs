namespace ExtraOefeningen.ViewModels;

public partial class AfbeeldingViewModel: BaseViewModel
{
    [ObservableProperty] int getal;
    [ObservableProperty] private string afbeelding;
    

    public AfbeeldingViewModel()
    {
        Title = "Afbeeldingen";
        Getal = 1;
        Afbeelding = "";
    }

    [RelayCommand]
    private void ToonAfbeelding()
    {
        switch (Getal)
        {
            case 1: Afbeelding = "moto1.jpg"; break;
            case 2: Afbeelding = "moto2.jpg"; break;
            case 3: Afbeelding = "moto3.jpg"; break;
            case 4: Afbeelding = "moto4.jpg"; break;
            case 5: Afbeelding = "moto5.jpg"; break;
        }
    }
}