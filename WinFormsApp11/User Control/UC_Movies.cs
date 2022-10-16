using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp11.Models;

namespace WinFormsApp11.User_Control
{
    public partial class UC_Movies : UserControl
    {
        public UC_Movies(Movie movie)
        {
            InitializeComponent();
            lblNameMovie.Text = movie.Title;
            lblImdb.Text = movie?.imdbRating?.ToString();
            lblYearMovie.Text = movie?.Year;
            pictureBox1.Load(movie?.Poster);
        }



    }
}
