using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight.Command;
using SerialTest.Annotations;

namespace SerialTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private string _serialPort;

        public string SerialPort {
            get => _serialPort;
            set { _serialPort = value; OnPropertyChanged(); }
        }

        public RelayCommand ChooseSerialPort { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel()
        {
            ChooseSerialPort = new RelayCommand(() =>
            {
                Console.WriteLine("Open Serial Ports....");
                SerialPort = "COM1";
                OnPropertyChanged(nameof(SerialPort));
            }, () => true);
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
