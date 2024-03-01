using System.Collections.ObjectModel;

namespace ExtraOefeningen.ViewModels;

public partial class FactuurViewModel : BaseViewModel
{
    [ObservableProperty] string productnaam;
    [ObservableProperty] double productPrijs;
    [ObservableProperty] int productAantal;
    [ObservableProperty] ObservableCollection<FactuurLijn> factuurLijnen;
    [ObservableProperty] double subtotaal;
    [ObservableProperty] double btw;
    [ObservableProperty] double eindTotaal;
    
    public FactuurViewModel()
    {
        Title = "Factuur";
        FactuurLijnen = [];
        Productnaam = "";
        ProductPrijs = 0;
        ProductAantal = 0;
        Subtotaal = 0;
        Btw = 0;
        EindTotaal = 0;
    }

    [RelayCommand]
    private void ProductToevoegen()
    {
        FactuurLijnen.Add(new FactuurLijn(Productnaam, ProductPrijs, ProductAantal));
        Subtotaal += ProductPrijs;
        Btw += ProductPrijs * 0.21;
        EindTotaal = Subtotaal + Btw;
        Productnaam = "";
        ProductPrijs = 0;
        ProductAantal = 0;
    }
}