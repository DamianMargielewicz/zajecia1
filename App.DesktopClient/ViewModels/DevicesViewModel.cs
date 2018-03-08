namespace App.DesktopClient.ViewModels
{
    using System.Threading.Tasks;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using App.Data;
    using App.Data.Interfaces;
    using Prism.Mvvm;
    using Data.Models;
    using System.Collections.ObjectModel;

    public class DevicesViewModel : BindableBase
    {
        private readonly IDataContextProvider _dataContextProvider;
        private readonly DataContext _dataContext;
        private ObservableCollection<Device> _resultOfSearchInDevices;
        private IEnumerable<Device> _devices;
        private string _searchExpression;


        public DevicesViewModel()
        {
            _dataContextProvider = new DataContextProvider();
            _dataContext = _dataContextProvider.GetContext();

            Task.Run(() => GetDevices());
        }


        public string SearchExpression
        {
            get { return _searchExpression; }
            set
            {
                _searchExpression = value;
                FilterDevices(_searchExpression);
            }
        }

        public ObservableCollection<Device> ResultOfSearchInDevices
        {
            get => _resultOfSearchInDevices;
            set
            {
                SetProperty(ref _resultOfSearchInDevices, value);
            }
        }

        public IEnumerable<Device> Devices
        {
            get { return _devices; }
            set
            {
                SetProperty(ref _devices, value);
                FilterDevices(_searchExpression);
            }
        }



        public void FilterDevices(string searchString)
        {
            IEnumerable<Device> res;
            if (string.IsNullOrWhiteSpace(searchString))
                res = Devices;
            else
                res = Devices.Where(d =>
                                    d.Name.IndexOf(searchString, StringComparison.CurrentCultureIgnoreCase) != -1)
                             .ToArray();

            ResultOfSearchInDevices = new ObservableCollection<Device>(res);
        }

        public void GetDevices()
        {
            var devices = _dataContext.Devices;
            Devices = new ObservableCollection<Device>(devices);
        }
    }
}
