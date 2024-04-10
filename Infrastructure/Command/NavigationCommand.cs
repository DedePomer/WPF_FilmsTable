using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.Infrastructure.Command.Base;
using WPF_SQL.Infrastructure.Navigation;
using WPF_SQL.View.Pages;
using WPF_SQL.ViewModel.Base;
using WPF_SQL.ViewModel.Pages;

namespace WPF_SQL.Infrastructure.Command
{
    internal class NavigationCommand<VM> : CommandBase where VM : ViewModelBase 
    {
        private NavigationStore _navigationStore;
        private readonly Func<VM> _createViewModel;

        public NavigationCommand(NavigationStore navigationStore, Func<VM> createViewModel)
        {
            _navigationStore = navigationStore;
            _createViewModel = createViewModel;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = _createViewModel();
        }
    }
}
