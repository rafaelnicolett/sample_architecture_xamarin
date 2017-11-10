using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using Sample.Arch.ViewModels;

namespace Sample.Arch.iOS
{
    public partial class SecondView : MvxViewController<SecondViewModel>
    {
        public SecondView() : base("SecondView", null)
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
            var binding = this.CreateBindingSet<SecondView, SecondViewModel>();

            binding.Bind(lblNameDevice).For(x => x.Text).To(x => x.NameDevice);

            binding.Apply();
        }
    }
}