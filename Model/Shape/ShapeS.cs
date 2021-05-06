﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Tetris.Model.Shape
{
    class ShapeS : BaseShape
    {
        public override void Create(int startY, int startX)
        {
            startY--;

            base.Points.Add(new Coordinate(startY, startX + 1));
            base.Points.Add(new Coordinate(startY + 1, startX + 1));
            base.Points.Add(new Coordinate(startY + 1, startX));
            base.Points.Add(new Coordinate(startY + 2, startX));
            base.SetColor(Colors.Lime);
        }
    }
}
