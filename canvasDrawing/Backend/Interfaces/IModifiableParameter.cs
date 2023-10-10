using System.Collections.Generic;

namespace canvasDrawing.Backend
{
    interface IModifiableParameter
    {

        List<string> getParamNames();
        void setParamValue(string name, int val);
        int getParamValue(string name);

    }
}
