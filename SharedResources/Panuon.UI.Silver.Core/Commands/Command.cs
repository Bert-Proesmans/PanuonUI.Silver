﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Panuon.UI.Silver.Core
{
    internal class Command : ICommand
    {
        #region Fields
        private Action<object> _executeAction;

        private Func<object, bool> _canExecuteFunc;
        #endregion

        #region Event
        public event EventHandler CanExecuteChanged;
        #endregion

        #region Ctor
        public Command(Action<object> executeAction, Func<object,bool> canExecuteFunc = null)
        {
            _executeAction = executeAction;
            _canExecuteFunc = canExecuteFunc;
        }
        #endregion

        #region Methods
        public void Execute(object parameter)
        {
            _executeAction?.Invoke(parameter);
        }

        public bool CanExecute(object parameter)
        {
            return _canExecuteFunc?.Invoke(parameter) ?? true;
        }
        #endregion
    }
}
