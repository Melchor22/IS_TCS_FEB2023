using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMonedas
{
    [DataContract]
    internal class Moneda
    {
        [DataMember]
        public float cantidadPeso { get; set; }
        [DataMember]
        public float cantidadDolar { get; set; }
    }
}
