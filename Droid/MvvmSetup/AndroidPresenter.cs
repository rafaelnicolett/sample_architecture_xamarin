using MvvmCross.Droid.Views;
using System.Collections.Generic;
using System.Reflection;

namespace Sample.Arch.Droid
{
    public class AndroidPresenter : MvxAndroidViewPresenter
    {
        public AndroidPresenter(IEnumerable<Assembly> assemblyes) : base(assemblyes)
        {

        }
    }
}