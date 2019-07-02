using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConverter
{
    public enum Temperature
    {
        Celcius,
        Fahrenheit,
        Kelvin
    }

   public class TemperatureConverter : UnitConverter<Temperature, float>
    {
         static TemperatureConverter()
        {
            BaseUnit = Temperature.Celcius;
            RegisterConversion(Temperature.Fahrenheit, v => (v * 9 / 5) + 32, v => (v - 32)  * 5 / 9);
            RegisterConversion(Temperature.Kelvin, v => v + 273.15F, v => v - 273.15F);
        }
    }
}