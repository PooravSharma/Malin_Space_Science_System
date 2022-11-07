using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Poorav Sharma 
//30045900
//A DLL project file with the following four mathematical formulas and save the file as AstroMath.DLL. 
namespace Astro_Math
{
    public class Calculate
    {
        static readonly int lightSpeed = 299792458;
        //A method to measure the Star velocity using the Doppler shift, it should have two input parameters of type double (Observed Wavelength and Rest Wavelength) and return a double which represents the velocity. The Doppler shift of a star can be measured by using the change in wavelength of that object.
        public static double Star_Velocity(double restWavelength, double observedWavelength)
        {

            double changedWavelength = observedWavelength - restWavelength;
            double velocity = (lightSpeed* changedWavelength)/restWavelength;
            return velocity;
        }
        //A method to measure the star distance using the parallax angle, it should have a single input parameter of type double (Arcseconds angle) and return a double. The parallax angle is measured at two different points and works on nearby stars. The method must return a double which is a value in parsecs.
        public static double Star_Distance(double arcseconds)
        {
            double distance = (1/arcseconds);
            return distance;
        }
        //A method that has a single input parameter of type double (temperature in Celsius) and returns a double which is the temperature in degrees kelvin. 
        public static double TemperatureChange(double celsius)
        {
            double kelvin = celsius + 273;
            return kelvin;

        }
        //Create a method that will return the distance from the centre of a blackhole to the event horizon. The method must have a single input parameter of type double (Blackhole Mass) and return a double which is the event horizon in metres. 
        public static double EventHorizon(double blackholeMass)
        {
            double gravityConstant = 6.674*Math.Pow(10, -11);
            double schwarzschildRadius = (2*blackholeMass*gravityConstant)/Math.Pow(lightSpeed, 2);
            return schwarzschildRadius;
        }
    }
}
