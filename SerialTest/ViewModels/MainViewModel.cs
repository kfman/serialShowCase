using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using SerialTest.Annotations;

namespace SerialTest.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private string _serialPort;

        public string SerialPort {
            get => _serialPort;
            set { _serialPort = value; RaisePropertyChanged(); }
        }

        public RelayCommand ChooseSerialPort { get; set; }


        public MainViewModel()
        {
            ChooseSerialPort = new RelayCommand(() =>
            {
                Console.WriteLine("Open Serial Ports....");
                SerialPort = "COM1";
            }, () => true);
        }

    }
}
