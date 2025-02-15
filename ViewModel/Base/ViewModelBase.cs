﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_SQL.ViewModel.Base
{
    internal abstract class ViewModelBase : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        //Попробую без метода SET
        //protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string? PropertyName = null) // ХЗ что это
        //{
        //    if (Equals(field, value)) return false;
        //    field = value;
        //    OnPropertyChanged(PropertyName);
        //    return true;
        //}

    }
}
