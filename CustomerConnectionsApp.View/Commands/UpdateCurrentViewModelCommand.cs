using CustomerConnectionsApp.WPF.State.Navigators;
using CustomerConnectionsApp.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CustomerConnectionsApp.WPF.Commands
{
    public class UpdateCurrentViewModelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private readonly INavigator navigator;

        public UpdateCurrentViewModelCommand(INavigator navigator)
        {
            this.navigator = navigator;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if(parameter is ViewType)
            {
                ViewType viewType = (ViewType)parameter;
                switch (viewType)
                {
                    case ViewType.Home:
                        navigator.CurrentViewModel = new HomeViewModel();
                        break;
                    case ViewType.Customer:
                        navigator.CurrentViewModel = new CustomerViewModel();
                        break;
                    case ViewType.Job:
                        navigator.CurrentViewModel = new JobViewModel();
                        break;
                    case ViewType.Hardware:
                        navigator.CurrentViewModel = new HardwareViewModel();
                        break;
                    default:
                        break;
                }
            }
        }
    }
}