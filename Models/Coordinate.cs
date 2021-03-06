using System;
using System.Windows.Media;

namespace Tetris.Models
{
    class Coordinate : ICloneable
    {
        public Coordinate(int x, int y)
        {
            X = x;
            Y = y;
        }

        public Coordinate(int x, int y, LinearGradientBrush pointColor)
        {
            X = x;
            Y = y;
            PointColor = pointColor;
        }

        public int X { get; set; }
        public int Y { get; set; }
        public LinearGradientBrush PointColor { get; set; }

        public object Clone()
        {
            return new Coordinate(this.X, this.Y, this.PointColor);
        }
    }
}
