using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Conversor
{
    public class ServicioMoneda : IServicioMoneda
    {
        public float GetPesos(float dolares)
        {
            float pesos = dolares * 18.00f;
            return pesos;
        }

        public float GetDolares(float pesos)
        {
            float dolares = pesos / 18.00f;
            return dolares;
        }
    }
}
