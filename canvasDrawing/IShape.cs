using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
namespace canvasDrawing
{
    public abstract class IShape
    {
        Dictionary<string, int> ParamVal { get; set; }

        public  abstract void draw(Canvas canvas);
    }
}
