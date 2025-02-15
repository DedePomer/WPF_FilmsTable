﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF_SQL.Infrastructure.Command.Base;

namespace WPF_SQL.Infrastructure.Command
{
    internal class LamdaCommand : CommandBase
    {
        private readonly Action<object> _Execute;
        private readonly Func<object?, bool> _CanExecute;

        public LamdaCommand(Action<object> Execute, Func<object, bool> CanExecute = null)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }


        public override void Execute(object? parameter) => _Execute(parameter);

        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;
    }
}
