using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UnitConverter.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult ConvertVolume(float? inputvolume, Volume inputunit, Volume outputunit)
        {
            if (ModelState.IsValid && inputvolume.HasValue)
            {

                var converter = new VolumeConverter();
                var result = converter.Convert(inputvolume.Value, inputunit, outputunit);

                var con = new UnitConverter.Dto.Convert();
                con.outputvolume = result;

                return View("Index", con);
            }
            else {
                return View("Index");
            }

    }

        public ActionResult ConvertTemp(float? inputtemp, Temperature inputunit, Temperature outputunit)
        {
            if (ModelState.IsValid && inputtemp.HasValue)
            {
                var converter = new TemperatureConverter();
                var result = converter.Convert(inputtemp.Value, inputunit, outputunit);

                var con = new UnitConverter.Dto.Convert();
                con.outputtemp = result;

                return View("Index", con);
            }
            else
            {
                return View("Index");
            }
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}