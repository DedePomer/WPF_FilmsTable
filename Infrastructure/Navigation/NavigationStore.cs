﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.ViewModel.Base;

namespace WPF_SQL.Infrastructure.Navigation
{
    internal class NavigationStore
    {
        //?
        public event Action CurrentViewModelChanged;

        //Здесь хранится текущаяя ViewModel
        private ViewModelBase? _currentViewModel;
        public ViewModelBase? CurrentViewModel 
        {             
            get => _currentViewModel;
            set
            {
                _currentViewModel = value;
                OnCurrentViewModelChanged();
            }
        }

        //?
        private void OnCurrentViewModelChanged()
        {
            CurrentViewModelChanged?.Invoke();
        }
    }
}
