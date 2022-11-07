using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using Astro_Math;
//Poorav Sharma 
//30045900
//ServiceContract file called “IAstroContract.cs” which will require an Interface that references the AstroMath.DLL and four OperationContract (one for each calculation). 
namespace IAstroContract
{
    [ServiceContract]
    internal interface IAstroContract
    {
        [OperationContract]
        double Star_Velocity(double restWavelength, double observedWavelength);
        [OperationContract]
        double Star_Distance(double arcseconds);
        [OperationContract]
        double TemperatureChange(double celsius);
        [OperationContract]
        double EventHorizon(double blackholeMass);
    }
}
