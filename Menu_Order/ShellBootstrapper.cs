using Caliburn.Micro;
using Menu_Order.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Menu_Order
{
    class ShellBootstrapper : BootstrapperBase
    {
        public ShellBootstrapper()
        {
            Initialize();
        }
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            DisplayRootViewFor<ShellViewModel>();
        }
    }
   
}
