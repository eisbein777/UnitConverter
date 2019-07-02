using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitConverter
{
    public enum Volume
    {
        Millilitre,
        Liter,
        Gallon
       
    }

    public class VolumeConverter : UnitConverter<Volume, float>
    {
        static VolumeConverter()
        {
            BaseUnit = Volume.Millilitre;
            RegisterConversion(Volume.Liter, v => v / 1000, v => v * 1000);
            RegisterConversion(Volume.Gallon, v => v / 3785.412F, v => v * 3785.412F);
        }
    }
}