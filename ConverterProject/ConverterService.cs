namespace ConverterProject
{
    public class ConverterService : IDisposable
    {
        public double GetFernhaitFromCelcius(double CL)
        {
            return (CL * 9.0f / 5.0f) + 32;
        }

        public double GetCelciusFromFernhait(double FR)
        {
            return (FR - 32) * 5.0f / 9.0f;
        }

        public void Dispose()
        {
           //Dispose()
            
        }
    }
}