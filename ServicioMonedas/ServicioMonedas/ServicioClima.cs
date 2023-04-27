using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServicioMonedas
{
    internal class ServicioClima : IServicioClima
    {
        public float GetCelcius(float TemperaturaFarenheit)
        {
            float TemperaturaCelcius = (TemperaturaFarenheit - 32.0f) *(5.0f / 9.0f);
            return TemperaturaCelcius;
        }

        public float GetFarenheit(float TemperaturaCelcius)
        {
            float TemperaturaFarenheit = (TemperaturaCelcius * (9 / 5)) + 32;
            return TemperaturaFarenheit;
        }
    }
}
