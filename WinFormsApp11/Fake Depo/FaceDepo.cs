using System.Text.Json;
using WinFormsApp11.Models;

namespace WinFormsApp11.Fake_Depo;

public class FakeDepo
{

    const string _apiKey = "580270e";
    const string _url = $"http://www.omdbapi.com/?apikey={_apiKey}";
    public static string[] Movies = new string[] { "Ezel", "Kurtlar Vadisi", "The Avengers", "Eşkıya Dünyaya Hükümdar Olmaz", "Ağanatiq", "Narcos" };

    public static List<Movie> GetMovies()
    {
        List<Movie> MoviesTemp = new List<Movie>();

        for (int i = 0; i < Movies.Length; i++)
        {
            string search = $"{_url}&t={Movies[i]}";


            using HttpClient client = new();
            string jsonStr = client.GetStringAsync(search).Result;


            var movie = JsonSerializer.Deserialize<Movie>(jsonStr);
            MoviesTemp.Add(movie!);
        }



        return MoviesTemp;

    }

}
