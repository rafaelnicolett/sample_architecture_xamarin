﻿using System;
using MvvmCross.Core.ViewModels;
using Sample.Arch.Services;

namespace Sample.Arch.ViewModels
{
    public class StartViewModel : BaseViewModel
    {
        readonly ISampleService _sampleService;

        public StartViewModel(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        MvxCommand _gotoSecondViewModelCommand;
        public MvxCommand GotoSecondViewModelCommand =>
            _gotoSecondViewModelCommand = _gotoSecondViewModelCommand ?? new MvxCommand(() => ShowViewModel<SecondViewModel>());

        string _myName;
        public string MyName
        {
            get { return _myName; }
            set { _myName = value; RaisePropertyChanged(); }
        }

        public void Init()
        {
            MyName = _sampleService.GetName();
        }
    }
}
