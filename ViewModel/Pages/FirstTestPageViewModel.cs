using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WPF_SQL.Infrastructure.Command;
using WPF_SQL.Infrastructure.Navigation;
using WPF_SQL.ViewModel.Base;

namespace WPF_SQL.ViewModel.Pages
{
    internal class FirstTestPageViewModel : ViewModelBase
    {
        public ICommand NavigateSecondTestCommand { get; }

        public FirstTestPageViewModel(NavigationStore navigationStore) 
        {
            NavigateSecondTestCommand = new NavigationCommand(navigationStore);
        }
    }
}
