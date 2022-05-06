using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Programming.Model.Geometry;
using Rectangle = Programming.Model.Geometry.Rectangle;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangles;

        private List<Panel> _rectanglePanels;

        private Rectangle _currentRectangle;

        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectanglePanels = new List<Panel>();

            _rectangles = new List<Rectangle>();
        }

        private void FindCollisions()
        {
            for (int i = 0; i < _rectanglePanels.Count; i++)
            {
                CanvasPanel.Controls[i].BackColor = AppColors.IsCollisionFalse;
            }

            for (int i = 0; i < _rectanglePanels.Count - 1; i++)
            {
                for (int j = i + 1; j < _rectanglePanels.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangles[i], _rectangles[j]))
                    {
                        CanvasPanel.Controls[i].BackColor = AppColors.IsCollisionTrue;
                        CanvasPanel.Controls[j].BackColor = AppColors.IsCollisionTrue;
                    }
                }
            }
        }

        private void ClearReactangleInfo()
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
                FindCollisions();
                UpdateRectangleInfo(_currentRectangle);
            }
            catch
            {
                HeightRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            HeightRectangle.BackColor = AppColors.CorrectColor;
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
                WidthRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            WidthRectangle.BackColor = AppColors.CorrectColor;
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
                XRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            XRectangle.BackColor = AppColors.CorrectColor;
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
                YRectangle.BackColor = AppColors.ErrorColor;
                return;
            }
            YRectangle.BackColor = AppColors.CorrectColor;
        }

        private void AddRectangleButton_Click(object sender, EventArgs e)
        {
            _currentRectangle = RectangleFactory.Randomize();
            _rectangles.Add(_currentRectangle);
            ListBoxRectanglesTabPage.Items.Add($"{_currentRectangle.Id}: (X= {_currentRectangle.Center.X}; Y= {_currentRectangle.Center.Y}; W= {_currentRectangle.Width}; H= {_currentRectangle.Height}) ");

            Panel rectanglePanel = new Panel();
            rectanglePanel.Width = _currentRectangle.Width;
            rectanglePanel.Height = _currentRectangle.Height;
            rectanglePanel.Location = new Point(_currentRectangle.Center.X, _currentRectangle.Center.Y);
            rectanglePanel.BackColor = AppColors.IsCollisionTrue;
            _rectanglePanels.Add(rectanglePanel);
            CanvasPanel.Controls.Add(rectanglePanel);

            FindCollisions();
        }

        private void RemoveRectangleButton_Click(object sender, EventArgs e)
        {
            int index = ListBoxRectanglesTabPage.SelectedIndex;
            if (index != -1)
            {
                _rectangles.RemoveAt(index);
                _rectanglePanels.RemoveAt(index);
                ListBoxRectanglesTabPage.Items.RemoveAt(index);
                CanvasPanel.Controls.RemoveAt(index);
                FindCollisions();
                ClearReactangleInfo();

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

        private void AddRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24;
        }

        private void AddRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            AddRectangleButton.Image = Properties.Resources.rectangle_add_24x24_uncolor;
        }

        private void RemoveRectangleButton_MouseEnter(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24;
        }

        private void RemoveRectangleButton_MouseLeave(object sender, EventArgs e)
        {
            RemoveRectangleButton.Image = Properties.Resources.rectangle_remove_24x24_uncolor;
        }
    }
}
