﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace FeatureProject.ViewModels
{
    public class RelayCommand : ICommand
    {

        readonly Action<object?> _execute;
        readonly Predicate<object?> _canExecute;

        public event EventHandler? CanExecuteChanged;

        public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        public RelayCommand(Action<object?> execute) : this(execute, null)
        {
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null ? true : _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _execute(parameter);
        }

        public void RaiseCanExecuteChanged()
        {
            if (_canExecute != null)
                CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }

    }
}
