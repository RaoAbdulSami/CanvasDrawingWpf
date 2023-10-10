using canvasDrawing.Backend;
using System.Collections.Generic;
using System.Windows.Controls;

namespace canvasDrawing
{

    public abstract class UpdatableShape : IModifiableParameter
    {
        public abstract string name { get; set; }

        protected Dictionary<string, int> parameters = new Dictionary<string, int>();
        public abstract List<string> getParamNames();
        public abstract int getParamValue(string name);
        public abstract void setParamValue(string name, int val);

        public abstract void draw(Canvas canvas);


    }






}
