using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.Infrastructure.Navigation;
using WPF_SQL.ViewModel.Base;

namespace WPF_SQL.ViewModel
{
    internal class MainWindowViewModel: ViewModelBase
    {
        // Навигация
        NavigationStore navigationStore = new NavigationStore();
        public ViewModelBase? CurrentViewModel => navigationStore.CurrentViewModel;

        public MainWindowViewModel()
        { 
            navigationStore.CurrentViewModel = new ;
        }
    }
}
