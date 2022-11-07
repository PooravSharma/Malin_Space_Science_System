using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
//Poorav Sharma 
//30045900
//ServiceContract called “IAstroContract.cs” which is identical to the server without a reference to the AstroMath.DLL.
namespace Malin_Space_Science_System
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
