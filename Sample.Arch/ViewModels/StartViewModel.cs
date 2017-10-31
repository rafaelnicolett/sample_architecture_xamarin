using System;
using MvvmCross.Core.ViewModels;
using Sample.Arch.Services;

namespace Sample.Arch.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        readonly ISampleService _sampleService;

        public StartViewModel(ISampleService sampleService) {
            _sampleService = sampleService;
        }

        public string MyName { get; set; }

        public void Init() {
            MyName = _sampleService.GetName();
        }
    }
}
