namespace ExtraOefeningen.Data.Repositories;

public class GameRepository
{
    private List<Game> Games = new()
    {
        new Game() { Id = 1, Naam = "Cluedo", Moeilijkheidsgraad = 2, Uitgever = "Hasbro Gaming" },
        new Game() { Id = 2, Naam = "Monopoly", Moeilijkheidsgraad = 3, Uitgever = "Parker" },
        new Game() { Id = 3, Naam = "Machiavelli", Moeilijkheidsgraad = 3, Uitgever = "999 Games" },
        new Game() { Id = 4, Naam = "Catan", Moeilijkheidsgraad = 4, Uitgever = "999 Games" },
        new Game() { Id = 5, Naam = "Carcassonne", Moeilijkheidsgraad = 4, Uitgever = "999 Games" },
        new Game() { Id = 6, Naam = "SpeakOut", Moeilijkheidsgraad = 5, Uitgever = "Hasbro Gaming" },
        new Game() { Id = 7, Naam = "Skyjo", Moeilijkheidsgraad = 1, Uitgever = "Magilano" },
    };
    
    // Methode om de werknemers op te vragen
    public List<Game> GetGames()
    {
        return Games;
    }
}