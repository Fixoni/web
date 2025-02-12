using System;
using System.Text.Json;

namespace cw7.Models;

public class GamesRepo
{
    private string _filePath;
    private List<Game>? _games;

    public GamesRepo(string filePath = "games.json")
    {
        _filePath = filePath;
        string content = File.ReadAllText(_filePath);
        _games = JsonSerializer.Deserialize<List<Game>>(content);
    }
    public List<Game>? Games
    {
        get { return _games; }
    }
    private void SaveChanges()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string content = JsonSerializer.Serialize(_games, options);
        File.WriteAllText(_filePath, content);
    }
    private int GetNextId() //autoincrement
    {
        return _games != null ? _games.Max(m => m.Id) + 1 : 1;
    }
    public void AddGame(Game game)
    {
        if (_games == null)
        {
            _games = new List<Game>();
        }
        game.Id = GetNextId();
        _games.Add(game);
        SaveChanges();
    }
    public void DeleteGame(Game game)
    {
        if (_games == null)
        {
            return;
        }
        Games?.Remove(game);
        SaveChanges();
    }


    public Game? GetById(int? id)
    {
        return Games != null
              ? Games.FirstOrDefault(m => m.Id == id)
              : null;
    }

    internal void UpdateGame(Game game)
    {
        var toUpdate = _games?.FirstOrDefault(m => m.Id == game.Id);
        if(toUpdate != null){
            toUpdate.Name = game.Name;
            toUpdate.Firm = game.Firm;
            toUpdate.Price = game.Price;
            toUpdate.Type = game.Type;
        }
    }
}