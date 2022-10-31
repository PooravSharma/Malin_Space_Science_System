using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Astro_Math
{
    public class Calculate
    {
        static readonly int lightSpeed = 299792458;

        public static double Star_Velocity(double restWavelength, double observedWavelength)
        {

            double changedWavelength = observedWavelength - restWavelength;
            double velocity = (lightSpeed* changedWavelength)/restWavelength;
            return velocity;
        }
        public static double Star_Distance(double arcseconds)
        {
            double distance = (1/arcseconds);
            return distance;
        }
        public static double TemperatureChange(double celsius)
        {
            double kelvin = celsius + 273;
            return kelvin;

        }
        public static double EventHorizon(double blackholeMass)
        {
            double gravityConstant = 6.674*Math.Pow(10, -11);
            double schwarzschildRadius = (2*blackholeMass*gravityConstant)/Math.Pow(lightSpeed, 2);
            return schwarzschildRadius;
        }
    }
}
