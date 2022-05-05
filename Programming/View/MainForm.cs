using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Enums;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Classes;
using Programming.Model.Geometry;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        private const int ElementsCount = 5;

        private readonly Color _errorColor = Color.LightPink;

        private readonly Color _correctColor = Color.White;

        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        private Movie[] _movies;

        private Movie _currentMovie;

        private Random _random;

        public MainForm ()
        {
            InitializeComponent ();

            Array typeValues = System.Enum.GetValues (typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;

            Array seasonValues = System.Enum.GetValues (typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add (value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;

            _random = new Random ();

            _rectanglePanels = new List<Panel> ();

            _rectangles = new List<Rectangle> ();

            //InitRectangles ();

            InitMovies ();
        }

        //private void InitRectangles ()
        //{
        //    _rectangles = new List<Rectangle> ();

        //    var colors = Enum.GetValues (typeof(Colors));
        //    for (int i = 0; i < ElementsCount; i++)
        //    {
        //        _currentRectangle = new Rectangle ();
        //        _currentRectangle.Width = _random.Next (1, 1001) / 10.0;
        //        _currentRectangle.Height = _random.Next (1, 1001) / 10.0;
        //        _currentRectangle.Color = colors.GetValue(_random.Next (0, colors.Length)).ToString ();
        //        _currentRectangle.Center = new Point2D (_random.Next(1, 100), _random.Next (1, 100));
        //        _rectangles.Add(_currentRectangle);
        //        RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");
        //    }
        //    RectanglesListBox.SelectedIndex = 0;
        //}
        private void FindCollisions()
        {
            for(int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 127, 255, 127);
            }

            for(int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for(int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if(CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = Color.FromArgb(127, 255, 127, 127);
                        CanvasPanel.Controls[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }

        private void ClearRectangleInfo()
        {
            ListBoxRectanglesTabPage.Items.Clear();
            IdRectangle.Clear();
            XRectangle.Clear();
            YRectangle.Clear();
            WidthRectangle.Clear();
            HeightRectangle.Clear();
        }
        
        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            int ind = ListBoxRectanglesTabPage.FindString(rectangle.Id.ToString());

            if (ind == -1) return;

            ListBoxRectanglesTabPage.Items[ind] = $"{rectangle.Id}: " +
                                                        $"(X= {rectangle.Center.X};" +
                                                        $" Y= {rectangle.Center.Y};" +
                                                        $" W= {rectangle.Width};" +
                                                        $" H= {rectangle.Height})";
        }

        private void InitMovies ()
        {
            _movies = new Movie[ElementsCount];

            var genres = Enum.GetValues (typeof(Genre));
            for (int i = 0; i < ElementsCount; i++)
            {
                _currentMovie = new Movie ();
                _currentMovie.Rating = _random.Next (101) / 10.0;
                _currentMovie.ReleaseYear = _random.Next (1900, 2023);
                _currentMovie.Genre = genres.GetValue (_random.Next(0, genres.Length)).ToString ();
                _currentMovie.Name = $"Movie {_currentMovie.Genre} {_currentMovie.ReleaseYear}";
                _currentMovie.DurationMinutes = _random.Next (151);
                _movies[i] = _currentMovie;
                MovieListBox.Items.Add ($"Movie {i + 1}");
            }
            MovieListBox.SelectedIndex = 0;
        }

        private int FindRectangleWithMaxWidth (List<Rectangle> rectangles)
        {
            int maxWidthIndex = 0;
            double max = 0;
            for (int i = 0; i < ElementsCount; i++)
            {
                if (rectangles[i].Width > max)
                {
                    max = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private int FindMovieWithMaxRating (Movie[] movies)
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

        private void EnumsListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            Array enumValues;
            ValuesListBox.Items.Clear ();
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Color:
                    enumValues = Enum.GetValues (typeof(Colors));
                    break;

                case Enums.Weekday:
                    enumValues = Enum.GetValues (typeof(Weekday));
                    break; 
 
                case Enums.Seasons: 
                    enumValues = Enum.GetValues (typeof(Season));
                    break; 
 
                case Enums.Manufactures: 
                    enumValues = Enum.GetValues (typeof(Manufactures));
                    break; 
 
                case Enums.Genre:
                    enumValues = Enum.GetValues (typeof(Genre));
                    break;                      
                                                
                case Enums.EducationForm:       
                    enumValues = Enum.GetValues (typeof(EducationForm));
                    break;                      
                                                
                default:
                    throw new NotImplementedException ();
            }

            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add (value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)item).ToString ();
        }

        private void RectanglesListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            if (RectanglesListBox.SelectedItem != null)
            {
                int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
                _currentRectangle = _rectangles[selectedIndexRectangle];
                LengthRectangleTextBox.Text = _currentRectangle.Height.ToString();
                WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
                ColorRectangleTextBox.Text = _currentRectangle.Color;
                XRectangleTextBox.Text = _currentRectangle.Center.X.ToString();
                YRectangleTextBox.Text = _currentRectangle.Center.Y.ToString();
                IdRectangleTextBox.Text = _currentRectangle.Id.ToString();
            }
        }

        private void LengthRectangleTextBox_TextChanged (object sender, EventArgs e)
        {
            try
            {
                string rectnagleCurrentLength = LengthRectangleTextBox.Text;
                int rectangleLength = int.Parse(rectnagleCurrentLength);
                _currentRectangle.Height = rectangleLength;
            }
            catch
            {
                LengthRectangleTextBox.BackColor = _errorColor;
                return;
            }
            LengthRectangleTextBox.BackColor = _correctColor;
        }

        private void WidthRectangleTextBox_TextChanged (object sender, EventArgs e)
        {
            try
            {
                string rectangleCurrentWidt = WidthRectangleTextBox.Text;
                int rectangleWidth = int.Parse (rectangleCurrentWidt);
                _currentRectangle.Width = rectangleWidth;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = _errorColor;
                return;
            }
            WidthRectangleTextBox.BackColor = _correctColor;
        }

        private void ColorRectangleTextBox_TextChanged (object sender, EventArgs e)
        {
            string rectangleCurrentColor = ColorRectangleTextBox.Text;
            _currentRectangle.Color = rectangleCurrentColor;
        }

        private void MovieListBox_SelectedIndexChanged (object sender, EventArgs e)
        {
            int movieSelectedIndex = MovieListBox.SelectedIndex;
            _currentMovie = _movies[movieSelectedIndex];
            MovieNameTextBox.Text = _currentMovie.Name;
            MovieGenreTextBox.Text = _currentMovie.Genre;
            MovieYearReleaseTextBox.Text = _currentMovie.ReleaseYear.ToString ();
            MovieDurationMinutesTextBox.Text = _currentMovie.DurationMinutes.ToString ();
            MovieRatingTextBox.Text = _currentMovie.Rating.ToString ();
        }

        private void NameMovieTextBox_TextChanged (object sender, EventArgs e)
        {
            string movieName = MovieNameTextBox.Text;
            _currentMovie.Name = movieName;
        }

        private void GenreMovieTextBox_TextChanged (object sender, EventArgs e)
        {
            string movieGenre = MovieGenreTextBox.Text;
            _currentMovie.Genre = movieGenre;
        }

        private void RatingMovieTextBox_TextChanged (object sender, EventArgs e)
        {
            try
            {
                string currentRating = MovieRatingTextBox.Text;
                double movieRating = double.Parse (currentRating);
                _currentMovie.Rating = movieRating;
            }
            catch
            {
                MovieRatingTextBox.BackColor = _errorColor;
                return;
            }
            MovieRatingTextBox.BackColor = _correctColor;
        }

        private void ReleaseYearMovieTextBox_TextChanged (object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = MovieYearReleaseTextBox.Text;
                int movieReleaseYear = int.Parse (currentYearRelease);
                _currentMovie.ReleaseYear = movieReleaseYear;
            }
            catch
            {
                MovieYearReleaseTextBox.BackColor = _errorColor;
                return;
            }
            MovieYearReleaseTextBox.BackColor = _correctColor;
        }

        private void DurationMinutesMovieTextBox_TextChanged (object sender, EventArgs e)
        {
            try
            {
                string durationAsString = MovieDurationMinutesTextBox.Text;
                int durationInMinutes = int.Parse (durationAsString);
                _currentMovie.DurationMinutes = durationInMinutes;
            }
            catch
            {
                MovieDurationMinutesTextBox.BackColor = _errorColor;
                return;
            }
            MovieDurationMinutesTextBox.BackColor = _correctColor;
        }

        private void ParseWeekdayButton_Click (object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday weekday;
            if (Enum.TryParse (textWeekdayTextBox, out weekday))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({weekday} - {(int)weekday})";
            }
            else
            {
                OutputWeekdayLabel.Text = "Нет такого дня недели";
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            switch (SeasonNamesComboBox.SelectedItem)
            {
                case Season.Winter:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show ("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show ("Ура! Солнце!");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml ("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml ("#e29c45");
                    break;
            }
        }

        private void FindButton_Click (object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth (_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void FindMovieButton_Click (object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindMovieWithMaxRating (_movies);
            MovieListBox.SelectedIndex = findMaxRatingIndex;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize();
            _rectangles.Add(_currentRectangle);
            ListBoxRectanglesTabPage.Items.Add($"{_currentRectangle.Id}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Height}) ");
            RectanglesListBox.Items.Add($"Rectangle {_currentRectangle.Id}");

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = Color.FromArgb(127, 127, 255, 127);
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxRectanglesTabPage.SelectedIndex;
            if(index != -1)
            {
                _rectangles.RemoveAt(index);
                _rectanglePanels.RemoveAt(index);
                ListBoxRectanglesTabPage.Items.RemoveAt(index);
                RectanglesListBox.Items.RemoveAt(index);
                CanvasPanel.Controls.RemoveAt(index);
                FindCollisions();
                ClearRectangleInfo();

                for (int i = 0; i < _rectangles.Count; i++)
                {
                    ListBoxRectanglesTabPage.Items.Add($"{_rectangles[i].Id}: " +
                                                  $"(X= {_rectangles[i].Center.X};" +
                                                  $" Y= {_rectangles[i].Center.Y};" +
                                                  $" W= {_rectangles[i].Width};" +
                                                  $" H= {_rectangles[i].Height})");
                    ListBoxRectanglesTabPage.SelectedIndex = 0;
                }
            }
        }

        private void ListBoxRectanglesTabPage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedItem != null)
            {
                int indexSelectedRectangle = ListBoxRectanglesTabPage.SelectedIndex;
                _currentRectangle = _rectangles[indexSelectedRectangle];
                IdRectangle.Text = _currentRectangle.Id.ToString();
                XRectangle.Text = _currentRectangle.Center.X.ToString();
                YRectangle.Text = _currentRectangle.Center.Y.ToString();
                WidthRectangle.Text = _currentRectangle.Width.ToString();
                HeightRectangle.Text = _currentRectangle.Height.ToString();
            }
            
        }

        private void HeightRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentHeight = HeightRectangle.Text;
                int rectangleHeight = int.Parse(rectnagleCurrentHeight);
                _currentRectangle.Height = rectangleHeight;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Height = _currentRectangle.Height;
                FindCollisions ();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightRectangle.BackColor = _errorColor;
                return;
            }
            HeightRectangle.BackColor = _correctColor;
        }

        private void WidthRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentWidth = WidthRectangle.Text;
                int rectangleWidth = int.Parse(rectnagleCurrentWidth);
                _currentRectangle.Width = rectangleWidth;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Width = _currentRectangle.Width;
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                WidthRectangle.BackColor = _errorColor;
                return;
            }
            WidthRectangle.BackColor = _correctColor;
        }

        private void XRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentX = XRectangle.Text;
                int rectangleX = int.Parse(rectnagleCurrentX);
                _currentRectangle.Center.X = rectangleX;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                XRectangle.BackColor = _errorColor;
                return;
            }
            XRectangle.BackColor = _correctColor;
        }

        private void YRectangle_TextChanged(object sender, EventArgs e)
        {
            if (ListBoxRectanglesTabPage.SelectedIndex == -1)
                return;
            try
            {
                string rectnagleCurrentY = YRectangle.Text;
                int rectangleY = int.Parse(rectnagleCurrentY);
                _currentRectangle.Center.Y = rectangleY;
                CanvasPanel.Controls[ListBoxRectanglesTabPage.SelectedIndex].Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                YRectangle.BackColor = _errorColor;
                return;
            }
            YRectangle.BackColor = _correctColor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }
    }
}