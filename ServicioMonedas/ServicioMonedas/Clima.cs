using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMonedas
{
    [DataContract]
    internal class Clima
    {
        [DataMember]
        public float TemperaturaCelcius { get; set; }
        [DataMember]
        public float TemperaturaFarenheit { get; set; }
    }
}
