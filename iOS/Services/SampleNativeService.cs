using Sample.Arch.Services;

namespace Sample.Arch.iOS.Services
{
    public class SampleNativeService : ISampleNativeService
    {
        public string GetNameDevice()
        {
            return "iOS";
        }
    }
}