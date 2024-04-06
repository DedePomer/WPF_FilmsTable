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
    internal class SecondTestPageViewModel : ViewModelBase
    {
        public ICommand NavigateFirstTestCommand { get; }

        public SecondTestPageViewModel(NavigationStore navigationStore, Func<FirstTestPageViewModel> createFirstTestPageViewModel)
        {
            NavigateFirstTestCommand = new NavigationCommand(navigationStore, createFirstTestPageViewModel);
        }

    }
}
