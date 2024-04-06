using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.Infrastructure.Command;
using WPF_SQL.Infrastructure.Navigation;
using WPF_SQL.ViewModel.Base;

namespace WPF_SQL.ViewModel.Pages
{
    internal class FilmsTablePageViewModel: ViewModelBase
    {

        public FilmsTablePageViewModel(NavigationStore navigationStore, Func<MenuPageViewModel> createMenuPageViewModel)
        {
            //NavigateSecondTestCommand = new NavigationCommand(navigationStore, createFilmsTablePageViewModel);
        }
    }
}
