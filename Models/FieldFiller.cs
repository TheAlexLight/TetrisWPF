using System.Collections.Generic;
using System.Linq;
using System.Windows.Media;
using System.Windows.Shapes;

using Tetris.Models.Shape;

namespace Tetris.Models
{
    class FieldFiller
    {
        public List<Coordinate> ListOfAllPoints { get; set; } = new List<Coordinate>();

        public List<List<Rectangle>> DrawShape(BaseShape shape, List<List<Rectangle>> listOfRectangles)
        {
            shape.Points.ForEach(p => {listOfRectangles = DrawOnePoint(p, listOfRectangles); });

            return listOfRectangles;
        }

        public List<List<Rectangle>> ClearPreviousShape(List<Coordinate> previousShapeCoordinate, List<List<Rectangle>> listOfRectangles)
        {
            for (int i = 0; i < previousShapeCoordinate.Count; i++)
            {
                listOfRectangles[previousShapeCoordinate[i].X][previousShapeCoordinate[i].Y].Fill = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#507387"));

               Coordinate coord = ListOfAllPoints.FirstOrDefault(p=>p.X == previousShapeCoordinate[i].X && p.Y == previousShapeCoordinate[i].Y);
                ListOfAllPoints.RemoveAll(p=>p==coord);
            }

            return listOfRectangles;
        }

        private List<List<Rectangle>> DrawOnePoint(Coordinate coord,  List<List<Rectangle>> listOfRectangles)
        {
            listOfRectangles[coord.X][coord.Y].Fill = new LinearGradientBrush(coord.PointColor.GradientStops);

            return listOfRectangles;
        }
    }
}
