using System;
using System.Windows.Input;

namespace MVVM_voorbeeld_Oplossing
{
    class Command : ICommand
    {

        private Action WhattoExecute;
        private Func<bool> WhentoExecute;

        public Command(Action What, Func<bool> When)
        {
            WhattoExecute = What;
            WhentoExecute = When;
        }

        public Command(Action What)
        {
            WhattoExecute = What;
        }

        public bool CanExecute(object parameter)
        {
            if (WhentoExecute == null)
            {
                return true;
            }
            return WhentoExecute();
        }

        public void Execute(object parameter)
        {
            WhattoExecute();
        }

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

    }
}
