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

        private Rectangle _currentRectangle;

        public MainForm ()
        {
            InitializeComponent ();

            Array typeValues = Enum.GetValues (typeof(Enums));
            foreach (Enums value in typeValues)
            {
                EnumsListBox.Items.Add(value);
            }

            EnumsListBox.SelectedIndex = 0;

            Array seasonValues = Enum.GetValues (typeof(Season));
            foreach (Season value in seasonValues)
            {
                SeasonNamesComboBox.Items.Add (value);
            }

            SeasonNamesComboBox.SelectedIndex = 0;

            _rectangles = new List<Rectangle> ();

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
    }
}