using canvasDrawing.Backend;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

     
    }

   



    
}
