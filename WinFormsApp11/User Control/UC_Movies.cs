using WinFormsApp11.Models;

namespace WinFormsApp11.User_Control;

public partial class UC_Movies : UserControl
{
    public UC_Movies(Movie movie)
    {
        InitializeComponent();
        pictureBox1.Load(movie?.Poster);
        lblNameMovie.Text = movie?.Title;
        lblImdb.Text = movie?.imdbRating?.ToString();
        lblYearMovie.Text = movie?.Year;
        lblGenreMovie.Text = movie?.Genre;
        lblWriterMovie.Text = movie?.Writer;
        lblActorsMovies.Text = movie?.Actors;
        lblLanguageMovies.Text = movie?.Language;
        lblCountryMovie.Text = movie?.Country;
        lblDirectorMovies.Text= movie?.Director;
        lblPlotMovies.Text = movie?.Plot;  
    }


}
