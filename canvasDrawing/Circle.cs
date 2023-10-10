using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
namespace canvasDrawing
{
    class Circle : UpdatableShape
    {
        public override string name { get; set; }


        public Circle()
        {
            parameters.Add("Radius", 40);

        }

        public override void draw(Canvas canvas)
        {
            System.Windows.Shapes.Ellipse rect = new System.Windows.Shapes.Ellipse
            {
                Height = parameters["Radius"],
                Width = parameters["Radius"],
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
