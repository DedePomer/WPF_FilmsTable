﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.Infrastructure.Command;
using WPF_SQL.Infrastructure.Navigation;
using WPF_SQL.View.Pages.Tests;
using WPF_SQL.ViewModel.Base;
using WPF_SQL.ViewModel.Pages;

namespace WPF_SQL.ViewModel
{
    internal class MainWindowViewModel: ViewModelBase
    {
        // Навигация
        NavigationStore navigationStore = new NavigationStore();
        public ViewModelBase? CurrentViewModel => navigationStore.CurrentViewModel;
        

        public MainWindowViewModel()
        {
            navigationStore.CurrentViewModel = CreateMenuPageViewModel();
            navigationStore.CurrentViewModelChanged += () => OnCurrentViewChanged();
        }

        private void OnCurrentViewChanged()
        {
            OnPropertyChanged(nameof(CurrentViewModel));
        }

        private MenuPageViewModel CreateMenuPageViewModel()
        {
            return new MenuPageViewModel(navigationStore, CreateFilmsTablePageViewModel);
        }

        private FilmsTablePageViewModel CreateFilmsTablePageViewModel()
        {
            return new FilmsTablePageViewModel(navigationStore, CreateMenuPageViewModel);
        }
    }
}
