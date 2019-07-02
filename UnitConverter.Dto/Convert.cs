using System;
using System.ComponentModel.DataAnnotations;

namespace UnitConverter.Dto
{
    public class Convert
    {


        public float inputtemp { get; set; }
        public float inputvolume { get; set; }
        public float outputtemp { get; set; }
        public float outputvolume { get; set; }
    }
}
