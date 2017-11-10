using Sample.Arch.Services;

namespace Sample.Arch.Droid.Services
{
    public class SampleNativeService : ISampleNativeService
    {
        public string GetNameDevice()
        {
            return "Android";
        }
    }
}