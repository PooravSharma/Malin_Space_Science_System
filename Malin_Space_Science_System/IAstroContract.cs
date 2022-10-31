using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

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
        double TemperatueChange(double celsius);
        [OperationContract]
        double EventHorizon(double blackholeMass);
    }
}
