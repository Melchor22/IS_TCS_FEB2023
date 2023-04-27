using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Conversor
{
    [ServiceContract]
    public interface IServicioMoneda
    {
        [OperationContract]
        float GetPesos(float dolares);

        [OperationContract]
        float GetDolares(float pesos);
    }
}
