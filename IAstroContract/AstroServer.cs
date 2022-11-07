using Astro_Math;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
//Server file called “AstroServer.cs” which implements the IAstroContract. A new instance of the class library method and then create four methods with the suitable input parameters and return types is added.
namespace IAstroContract
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {       
        public double Star_Velocity(double restWavelength, double observedWavelength)
        {
          return Calculate.Star_Velocity(restWavelength, observedWavelength);
        }
        public double Star_Distance(double arcseconds)
        {
           return Calculate.Star_Distance(arcseconds);
        }
        public double TemperatureChange(double celsius)
        {
            return Calculate.TemperatureChange(celsius);
        }
        public double EventHorizon(double blackholeMass)
        {
            return Calculate.EventHorizon(blackholeMass);
        }
    }
}
