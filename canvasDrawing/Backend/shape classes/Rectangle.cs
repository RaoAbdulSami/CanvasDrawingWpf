using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Media;
namespace canvasDrawing
{
    class Rectangle : UpdatableShape
    {
        public override string name { get; set; }

        public Rectangle()
        {

            parameters.Add("width", 40);
            parameters.Add("height", 40);
        }

        public override void draw(Canvas canvas)
        {
            System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle
            {
                Height = parameters["height"],
                Width = parameters["width"],
                Fill = Brushes.Red
            };

            canvas.Children.Add(rect);

        }

        public override List<string> getParamNames()
        {

            return parameters.Keys.ToList();
        }


        public override int getParamValue(string name)
        {
            if (parameters.ContainsKey(name))
            {
                return parameters[name];
            }

            else return 0;
        }

        public override void setParamValue(string name, int val)
        {
            parameters[name] = val;

        }



    }
}
