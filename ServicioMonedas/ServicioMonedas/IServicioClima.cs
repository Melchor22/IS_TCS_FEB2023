using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMonedas
{
    [ServiceContract]
    internal interface IServicioClima
    {
        [OperationContract]
        float GetCelcius(float TemperaturaFarenheit);
        [OperationContract]
        float GetFarenheit(float TemperaturaCelcius);
    }
}
