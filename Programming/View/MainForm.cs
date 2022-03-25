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
using Rectangle = Programming.Model.Classes.Rectangle;
using Programming.Model.Classes;


namespace Programming.View
{
    public partial class MainForm : Form
    {
        const int CountElements = 5;

        Color ErrorColor = Color.LightPink;

        Color CorrectColor = Color.White;

        private Rectangle[] _rectangles;

        private Rectangle _currentRectangle;

        private Film[] _films;

        private Film _currentFilm;

        private Random _randomValues;

        public MainForm()
        {
            InitializeComponent();

            Array typeValues = System.Enum.GetValues(typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;

            Array seasonValues = System.Enum.GetValues(typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add(value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;

            _randomValues = new Random();
            _rectangles = new Rectangle[CountElements];
            var colors = Enum.GetValues(typeof(Colors));
            for (int i = 0; i < CountElements; i++)
            {
                _currentRectangle = new Rectangle();
                _currentRectangle.Width = _randomValues.Next(1, 1001) / 10.0;
                _currentRectangle.Length = _randomValues.Next(1, 1001) / 10.0;
                _currentRectangle.Color = colors.GetValue(_randomValues.Next(0, colors.Length)).ToString();
                _rectangles[i] = _currentRectangle;
                RectanglesListBox.Items.Add($"Rectangle {i + 1}");
            }
            RectanglesListBox.SelectedIndex = 0;

            _films = new Film[CountElements];
            var genres = Enum.GetValues(typeof(Genre));
            for (int i = 0; i < CountElements; i++)
            {
                _currentFilm = new Film();
                _currentFilm.Rating = _randomValues.Next(101) / 10.0;
                _currentFilm.YearOfRelease = _randomValues.Next(1900, 2023);
                _currentFilm.Genre = genres.GetValue(_randomValues.Next(0, genres.Length)).ToString();
                _currentFilm.Name = $"Film {_currentFilm.Genre} {_currentFilm.YearOfRelease}";
                _currentFilm.DurationInMinutes = _randomValues.Next(151);
                _films[i] = _currentFilm;
                FilmListBox.Items.Add($"Film {i + 1}");
            }
            FilmListBox.SelectedIndex = 0;
        }

        private void EnumsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Array enumValues;
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedItem)
            {
                case Enums.Color:
                    enumValues = Enum.GetValues(typeof(Colors));
                    break;

                case Enums.Weekday:
                    enumValues = Enum.GetValues(typeof(Weekday));
                    break;

                case Enums.Seasons:
                    enumValues = Enum.GetValues(typeof(Season));
                    break;

                case Enums.Manufactures:
                    enumValues = Enum.GetValues(typeof(Manufactures));
                    break;

                case Enums.Genre:
                    enumValues = Enum.GetValues(typeof(Genre));
                    break;

                case Enums.EducationForm:
                    enumValues = Enum.GetValues(typeof(EducationForm));
                    break;

                default:
                    throw new NotImplementedException();
            }

            foreach (var value in enumValues)
            {
                ValuesListBox.Items.Add(value);
            }
        }

        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = ValuesListBox.SelectedItem;
            IntValueTextBox.Text = ((int)item).ToString();
        }

        private void ParseWeekdayButton_Click(object sender, EventArgs e)
        {
            string textWeekdayTextBox = WeekdayTextBox.Text;
            Weekday value;
            if (Enum.TryParse(textWeekdayTextBox, out value))
            {
                OutputWeekdayLabel.Text = $"Это день недели ({value} - {(int)value})";
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
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Summer:
                    this.BackColor = DefaultBackColor;
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Spring:
                    this.BackColor = ColorTranslator.FromHtml("#559c45");
                    break;
                case Season.Autumn:
                    this.BackColor = ColorTranslator.FromHtml("#e29c45");
                    break;
            }
        }

        private void RectanglesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexRectangle = RectanglesListBox.SelectedIndex;
            _currentRectangle = _rectangles[selectedIndexRectangle];
            LengthRectangleTextBox.Text = _currentRectangle.Length.ToString();
            WidthRectangleTextBox.Text = _currentRectangle.Width.ToString();
            ColorRectangleTextBox.Text = _currentRectangle.Color;
        }

        private void LengthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentLengthRectangle = LengthRectangleTextBox.Text;
                double lengthRectangleValue = double.Parse(currentLengthRectangle);
                _currentRectangle.Length = lengthRectangleValue;
            }
            catch
            {
                LengthRectangleTextBox.BackColor = ErrorColor;
                return;
            }
            LengthRectangleTextBox.BackColor = CorrectColor;
        }

        private void WidthRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentWidtRectangle = WidthRectangleTextBox.Text;
                double widthRectangleValue = double.Parse(currentWidtRectangle);
                _currentRectangle.Width = widthRectangleValue;
            }
            catch
            {
                WidthRectangleTextBox.BackColor = ErrorColor;
                return;
            }
            WidthRectangleTextBox.BackColor = CorrectColor;
        }

        private void ColorRectangleTextBox_TextChanged(object sender, EventArgs e)
        {
            string currentColorRectangle = ColorRectangleTextBox.Text;
            _currentRectangle.Color = currentColorRectangle;
        }

        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            int maxWidthIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (rectangles[i].Width > maxValue)
                {
                    maxValue = rectangles[i].Width;
                    maxWidthIndex = i;
                }
            }
            return maxWidthIndex;
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
            int findMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            RectanglesListBox.SelectedIndex = findMaxWidthIndex;
        }

        private void FilmListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndexFilm = FilmListBox.SelectedIndex;
            _currentFilm = _films[selectedIndexFilm];
            NameFilmTextBox.Text = _currentFilm.Name;
            GenreFilmTextBox.Text = _currentFilm.Genre;
            YearReleaseFilmTextBox.Text = _currentFilm.YearOfRelease.ToString();
            DurationMinutesFilmTextBox.Text = _currentFilm.DurationInMinutes.ToString();
            RatingFilmTextBox.Text = _currentFilm.Rating.ToString();
        }

        private void NameFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            string nameFilmValue = NameFilmTextBox.Text;
            _currentFilm.Name = nameFilmValue;
        }

        private void GenreFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            string genreFilmValue = GenreFilmTextBox.Text;
            _currentFilm.Genre = genreFilmValue;
        }

        private void YearReleaseFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentYearRelease = YearReleaseFilmTextBox.Text;
                int yearReleaseFilmValue = int.Parse(currentYearRelease);
                _currentFilm.YearOfRelease = yearReleaseFilmValue;
            }
            catch
            {
                YearReleaseFilmTextBox.BackColor = ErrorColor;
                return;
            }
            YearReleaseFilmTextBox.BackColor = CorrectColor;
        }

        private void DurationMinutesFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentDurationMinutes = DurationMinutesFilmTextBox.Text;
                int durationMinutesFilmValue = int.Parse(currentDurationMinutes);
                _currentFilm.DurationInMinutes = durationMinutesFilmValue;
            }
            catch
            {
                DurationMinutesFilmTextBox.BackColor = ErrorColor;
                return;
            }
            DurationMinutesFilmTextBox.BackColor = CorrectColor;
        }

        private void RatingFilmTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string currentRating = RatingFilmTextBox.Text;
                double ratingFilmValue = double.Parse(currentRating);
                _currentFilm.Rating = ratingFilmValue;
            }
            catch
            {
                RatingFilmTextBox.BackColor = ErrorColor;
                return;
            }
            RatingFilmTextBox.BackColor = CorrectColor;
        }

        private int FindFilmWithMaxRating(Film[] films)
        {
            int maxRatingIndex = 0;
            double maxValue = 0;
            for (int i = 0; i < CountElements; i++)
            {
                if (films[i].Rating > maxValue)
                {
                    maxValue = films[i].Rating;
                    maxRatingIndex = i;
                }
            }
            return maxRatingIndex;
        }

        private void FindFilmButton_Click(object sender, EventArgs e)
        {
            int findMaxRatingIndex = FindFilmWithMaxRating(_films);
            FilmListBox.SelectedIndex = findMaxRatingIndex;
        }
    }
}