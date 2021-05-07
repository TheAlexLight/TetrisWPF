﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris.Model.Shape
{
    class ShapeZ : BaseShape
    {
        public override void Create(int startY, int startX)
        {
            startY--;

            base.Points.Add(new Coordinate(startY, startX));
            base.Points.Add(new Coordinate(startY + 1, startX));
            base.Points.Add(new Coordinate(startY + 1, startX + 1));
            base.Points.Add(new Coordinate(startY + 2, startX + 1));
            base.SetColor(Colors.Red);
        }
    }
}