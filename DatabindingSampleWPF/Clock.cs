using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace DatabindingSampleWPF
{
    public class Clock : ObservableObject
    {
        private DispatcherTimer _timer;

        public Clock()
        {
            _timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };
            _timer.Tick += (sender, o) => RaisePropertyChanged(nameof(CurrentTime));
            _timer.Start();
        }

        public string CurrentTime => DateTime.Now.ToLongTimeString();

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
