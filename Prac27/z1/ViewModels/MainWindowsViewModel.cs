using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using z1.Commands;
using z1.Models;
using z1.Share;

namespace z1.ViewModels
{
    internal class MainWindowsViewModel : INotifyPropertyChanged
    {
        private string _path;
        private XmlDocumentWorker _xmlDocWorker;

        private List<Auto> _autos;

        private string _stamp;
        public string Stamp
        {
            get { return _stamp; }
            set
            {
                _stamp = value;
                OnPropertyChanged("Stamp");
            }
        }

        private int _yearRelease;
        public string YearRelease
        {
            get { return _yearRelease.ToString(); }
            set
            {
                try
                {
                    _yearRelease = Convert.ToInt32(value);
                    OnPropertyChanged("YearRelease");
                }
                catch (FormatException)
                {
                }
            }
        }

        private int _parkingRentalPeriod;
        public string ParkingRentalPeriod
        {
            get { return _parkingRentalPeriod.ToString(); }
            set
            {
                try
                {
                    _parkingRentalPeriod = Convert.ToInt32(value);
                    OnPropertyChanged("ParkingRentalPeriod");
                }
                catch (FormatException)
                {
                }
            }
        }

        private Command _open;
        public Command Open
        {
            get
            {
                return _open ??
                    (_open = new Command(obj => OpenFile()));
            }
        }

        private Command _add;
        public Command Add
        {
            get
            {
                return _add ??
                    (_add = new Command(obj =>
                    {
                        AddAuto(_stamp, _yearRelease, _parkingRentalPeriod);
                    }));
            }
        }

        private Command _delete;
        public Command Delete
        {
            get
            {
                return _delete ??
                    (_delete = new Command(obj =>
                    {
                        string id = obj as string;
                        if (id != null)
                        {
                            DeleteAuto(id);
                        }
                    }));
            }
        }

        private string _readData;
        public string ReadData
        {
            get
            {
                return _readData;
            }
            set
            {
                _readData = value;
                OnPropertyChanged("ReadData");
            }
        }

        public MainWindowsViewModel()
        {
            _xmlDocWorker = new XmlDocumentWorker();
        }

        private void OpenFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                ReadData = string.Empty;
                _path = openFileDialog.FileName;
                _xmlDocWorker.Load(_path);
                _autos = _xmlDocWorker.GetAll();
                ReadData = GetText();
            }
        }

        private void AddAuto(string stamp,
            int yearRelease, int parkingRentalPeriod)
        {
            if (_xmlDocWorker.Doc != null)
            {
                Auto auto = new Auto(0, stamp, yearRelease,
                    parkingRentalPeriod);
                _xmlDocWorker.Add(auto);
                _autos = _xmlDocWorker.GetAll();
                ReadData = GetText();
            }
            else
            {
                MessageBox.Show(
                        "Для начало откройте файл",
                        "Файл",
                        MessageBoxButton.OK);
            }
        }

        private void DeleteAuto(string id)
        {
            if (_xmlDocWorker.Doc != null)
            {
                try
                {
                    int idInt = Convert.ToInt32(id);
                    _xmlDocWorker.Delete(idInt);
                    _autos = _xmlDocWorker.GetAll();
                    ReadData = GetText();
                }
                catch (FormatException)
                {
                    MessageBox.Show(
                        "Неправельный формат поля",
                        "Формат",
                        MessageBoxButton.OK);
                }
            }
            else
            {
                MessageBox.Show(
                        "Для начало откройте файл",
                        "Файл",
                        MessageBoxButton.OK);
            }
        }

        private string GetText()
        {
            if (_autos != null)
            {
                if (_autos.Count != 0)
                {
                    _readData = string.Empty;
                    foreach (Auto a in _autos)
                    {
                        _readData += a.ToString();
                    }
                    return _readData;
                }
            }
            return string.Empty;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
