using System.Collections.ObjectModel;

namespace ExtraOefeningen.ViewModels;

public partial class PersoonToevoegenViewModel: BaseViewModel
{
    [ObservableProperty] public ObservableCollection<Persoon> personen;
    
    [ObservableProperty] private Persoon newPersoon;

    public PersoonToevoegenViewModel()
    {
        Personen = [];
        newPersoon = new ();
    }
    
    [RelayCommand]
    private void PersoonToevoegen()
    {
        Personen.Add(newPersoon);
    }

    [RelayCommand]
    private async Task PersonenTonen()
    {
        await Shell.Current.GoToAsync(nameof(PersonenTonen), true, new Dictionary<string, object>
        {
            { "Personen", Personen }
        });
    }
}