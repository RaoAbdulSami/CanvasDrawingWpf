using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace canvasDrawing.Backend
{
    interface IModifiableParameter
    {

        List<string> getParamNames();
        void setParamValue(string name, int val);
        int getParamValue(string name);

    }
}
