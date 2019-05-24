using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DatabindingSampleWPF
{
    public class MainWindowDataContext: ObservableObject
    {
        private bool _isNameNeeded = true;

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                RaisePropertyChanged(nameof(IsSubmitAllowed));
            }
        }

        public bool IsSubmitAllowed => !string.IsNullOrEmpty(UserName);

        public bool IsNameNeeded { get { return _isNameNeeded; }
            set
            {
                if(Set(ref _isNameNeeded, value))
                {
                    RaisePropertyChanged(nameof(GreetingVisibility));
                }
            }
        }

        public Visibility GreetingVisibility => IsNameNeeded ? Visibility.Collapsed : Visibility.Visible;

    }
}
