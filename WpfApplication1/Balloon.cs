﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {
        private int x = 10;
        private int y = 100;
        private int diameter = 10;
        private Color achtergrond = Colors.Gray;

        Ellipse ellipse = new Ellipse();

        static Random rndGen = new Random();

        public Balloon(Canvas canvas)
        {
            diameter = rndGen.Next(10, 30);
            y = rndGen.Next(10, 200);
            
            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter)
        {
            this.diameter = diameter;
            y = rndGen.Next(10, 200);

            UpdateEllipse(canvas);
        }

        public Balloon(Canvas canvas, int diameter, int height)
        {
            this.diameter = diameter;
            y = height;

            UpdateEllipse(canvas);
        }

        void UpdateEllipse(Canvas canvas)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            x = rndGen.Next(10, 300);
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.Fill = new SolidColorBrush(achtergrond);
            canvas.Children.Add(ellipse);
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void Move()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

    }
}
