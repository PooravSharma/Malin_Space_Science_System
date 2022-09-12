namespace AstroMath
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
        public static double TemperatueChange(double celsius)
        {   
            double kelvin = celsius + 273;
            return kelvin;

        }
        public static double EventHorizon(double blackholeMass)
        {
            double gravityConstant = 6.674*Math.Pow(10, -11);
            double schwarzschildRadius = (2*blackholeMass*gravityConstant)/Math.Pow(lightSpeed,2);
            return schwarzschildRadius;
        }
    }
}