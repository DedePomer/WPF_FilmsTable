﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.Infrastructure.Command.Base;
using WPF_SQL.Infrastructure.Navigation;
using WPF_SQL.View.Pages.Tests;
using WPF_SQL.ViewModel.Base;
using WPF_SQL.ViewModel.Pages;

namespace WPF_SQL.Infrastructure.Command
{
    internal class NavigationCommand : CommandBase
    {
        private NavigationStore _navigationStore;

        public NavigationCommand(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }

        public override bool CanExecute(object? parameter)
        {
            return true;
        }

        public override void Execute(object? parameter)
        {
            _navigationStore.CurrentViewModel = new SecondTestPageViewModel();
        }
    }
}
