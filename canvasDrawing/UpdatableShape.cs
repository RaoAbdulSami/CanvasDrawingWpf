using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace canvasDrawing
{
    public interface IModifiableParameter
    {

        List<string> getParamNames();
        void setParamValue(string name, int val);
        int getParamValue(string name);

        

    }
    public abstract class UpdatableShape : IShape, IModifiableParameter
    {
        public abstract string name { get; set; }

        protected Dictionary<string, int> parameters = new Dictionary<string, int>();
        public abstract List<string> getParamNames();
        public abstract int getParamValue(string name);
        public abstract void setParamValue(string name, int val);

     
    }

   



    
}
