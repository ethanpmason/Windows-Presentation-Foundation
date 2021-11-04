using CustomerConnectionsApp.WPF.State.Navigators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerConnectionsApp.WPF.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        //controls navigation
        public INavigator Navigator { get; set; } = new Navigator();
    }
}
