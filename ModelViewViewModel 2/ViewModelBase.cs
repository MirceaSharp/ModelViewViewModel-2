using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MVVM_voorbeeld_Oplossing
{
    abstract class ViewModelBase : INotifyPropertyChanged, IDataErrorInfo
    {
        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Methods

        protected void RaisePropertyChanged(string propertyName)
        {
            // take a copy to prevent thread issues
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion

        protected Dictionary<string, string> _errors = new Dictionary<string, string>();

        public string Error
        {
            get
            {
                string result = "";
                foreach (string item in _errors.Values)
                {
                    result += item + Environment.NewLine;
                }
                return result;
            }
        }

        protected bool IsValid()
        {
            if (_errors.Values.Count <= 0)
            {
                return true;
            }
            return false;
        }

        public abstract string this[string columnName] { get; }

    }
}
