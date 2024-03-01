namespace ExtraOefeningen.ViewModels;

public partial class GetallenDoorgeven1ViewModel: BaseViewModel
{
    [ObservableProperty] private int getal1;
    [ObservableProperty] private int getal2;

    private string Result;
    
    private void CompareValues()
    {
        if (Getal1 < Getal2)
            Result = $"{Getal2} is groter dan {Getal1}";
        else if (Getal1 > Getal2)
            Result = $"{Getal1} is groter dan {Getal2}";
        else Result = "Beide getallen zijn gelijk";
    }

    [RelayCommand]
    public async Task Doorgeven()
    {
        CompareValues();
        await Shell.Current.GoToAsync(nameof(GetallenDoorgeven2), true, new Dictionary<string, object>
        {
            { "Result", Result}
        });
    }
}