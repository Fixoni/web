using System;
using MySql.Data.MySqlClient;

namespace cw11_layout.Models;

public class MySqlFilmRepo
{
    private readonly string? _connectionString;

    public MySqlFilmRepo(string? connectionString)
    {
        _connectionString = connectionString;
    }

    public void AddFilm(MyFilm film)
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "INSERT INTO films (title, director, release_year) VALUES "
            + $"('{film.Title}', '{film.Director}', {film.ReleaseYear})";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public void DeleteFilm(int id)
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = $"DELETE FROM films WHERE id = {id}";
        connection.Open();
        command.ExecuteNonQuery();
        connection.Close();
    }

    public List<MyFilm> GetAllFilms()
    {
        using var connection = new MySqlConnection(_connectionString);
        MySqlCommand command = connection.CreateCommand();
        command.CommandText = "SELECT * FROM films";
        connection.Open();
        List<MyFilm> films = new List<MyFilm>();
        var reader = command.ExecuteReader();
        while (reader.Read())
        {
            films.Add(new MyFilm
            {
                Id = reader.GetInt32(0),
                Title = reader.GetString(1),
                Director = reader.GetString(2),
                ReleaseYear = reader.GetInt32(3)
            });
        }
        connection.Close();
        return films;
    }

    public MyFilm? GetFilmById(int id)
    {
        throw new NotImplementedException();
    }

    public void UpdateFilm(MyFilm film)
    {
        throw new NotImplementedException();
    }
}