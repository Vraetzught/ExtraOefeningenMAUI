namespace ExtraOefeningen.ViewModels;

[QueryProperty(nameof(Result), "Result")]

public partial class GetallenDoorgeven2ViewModel : BaseViewModel
{
    [ObservableProperty] private string result;
}