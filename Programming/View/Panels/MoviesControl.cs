using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;
using Programming.Model.Enums;

namespace Programming.View.Panels
{
    public partial class MoviesControl : UserControl
    {
        private const int ElementsCount = 5;

        private Movie[] _movies;

        private Movie _currentMovie;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private Random _random;

        public MoviesControl()
        {
            InitializeComponent();

            _random = new Random();

            InitMovies();
        }

        private void InitMovies()
        {
            _movies = new Movie[ElementsCount];

            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie();
                _currentMovie.Rating = _random.Next(101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next(1900, 2023);
                _currentMovie.Genre = genres.GetValue(_random.Next(0, genres.Length)).ToString();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next(151);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private int FindMovieWithMaxRating(Movie[] movies)
        {
            int maxRatingIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (movies[i].Rating > max)
                {
                    max = movies[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void MovieListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int movieSelectedIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[movieSelectedIndex];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieYearReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString();
            MovieDurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString();
        }

        private void MovieNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string movieName = MovieNameTextBox.Text;
            _currentMovie.Name = movieName;
        }

        private void MovieGenreTextBox_TextChanged(object sender, EventArgs e)
        {
            string movieGenre = MovieGenreTextBox.Text;
            _currentMovie.Genre = movieGenre;
        }

        private void MovieRatingTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = MovieRatingTextBox.Text;
                double movieRating = double.Parse(currentRating);
                _currentMovie.Rating = movieRating;
            }
            catch
            {
                MovieRatingTextBox.BackColor = _errorColor;
                return;
            }
            MovieRatingTextBox.BackColor = _correctColor;
        }

        private void MovieYearReleaseTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = MovieYearReleaseTextBox.Text;
                int movieReleaseYear = int.Parse(currentYearRelease);
                _currentMovie.ReleaseYear = movieReleaseYear;
            }
            catch
            {
                MovieYearReleaseTextBox.BackColor = _errorColor;
                return;
            }
            MovieYearReleaseTextBox.BackColor = _correctColor;
        }

        private void MovieDurationMinutesTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string durationAsString = MovieDurationMinutesTextBox.Text;
                int durationInMinutes = int.Parse(durationAsString);
                _currentMovie.DurationMinutes = durationInMinutes;
            }
            catch
            {
                MovieDurationMinutesTextBox.BackColor = _errorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = _correctColor;
        }

        private void FindMovieButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating(_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}
