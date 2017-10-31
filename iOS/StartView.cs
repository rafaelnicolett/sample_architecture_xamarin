using System;
using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Sample.Arch.ViewModels;
using UIKit;

namespace Sample.Arch.iOS
{
    public partial class StartView : MvxViewController<StartViewModel>
    {
        public StartView() : base("StartView", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            CreateBind();
        }

        void CreateBind()
        {
            var binding = this.CreateBindingSet<StartView, StartViewModel>();

            binding.Bind(lblName).For(x => x.Text).To(x => x.MyName);
            binding.Bind(txtName).For(x => x.Text).To(x => x.MyName);

            binding.Apply();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

