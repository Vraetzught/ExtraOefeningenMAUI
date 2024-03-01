using System.Collections.ObjectModel;

namespace ExtraOefeningen.ViewModels;

public partial class GameViewModel : BaseViewModel
{
    private GameRepository _repo;

    [ObservableProperty] private Game game;
    [ObservableProperty] private ObservableCollection<Game> games;
    [ObservableProperty] private Game selectedGame;

    public GameViewModel(GameRepository Repo)
    {
        Title = "Game page";
        _repo = Repo;
        Game = new Game();
        Games = new ObservableCollection<Game>(_repo.GetGames());
    }

    [RelayCommand]
    private void GameToevoegen()
    {
        if (!Games.Contains(Game))
            Games.Add(Game);
    }

    [RelayCommand]
    private void VeldenLeegmaken()
    {
        Game = new Game();
    }

    [RelayCommand]
    private void CopySelectedGame()
    {
        Game = SelectedGame;
    }
}