using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvasDrawing
{
    public class ShapeEventArgs : EventArgs
    {
        public double Length { get; }
        public double Width { get; }

        public double Radius { get; }

        public ShapeEventArgs(double length = 0, double width = 0, double radius = 0)
        {
            Length = length;
            Width = width;
            Radius = radius;
        }
    }
}
