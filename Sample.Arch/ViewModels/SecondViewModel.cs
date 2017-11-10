using Sample.Arch.Services;

namespace Sample.Arch.ViewModels
{
    public class SecondViewModel : BaseViewModel
    {
        readonly ISampleNativeService _sampleServiceNative;

        public SecondViewModel(ISampleNativeService sampleServiceNative)
        {
            _sampleServiceNative = sampleServiceNative;
        }

        string _nameDevice;
        public string NameDevice
        {
            get { return _nameDevice; }
            set { _nameDevice = value; RaisePropertyChanged(); }
        }

        public void Init()
        {
            NameDevice = _sampleServiceNative.GetNameDevice();
        }
    }
}
