using ModuleA.Models;
using Prism.Mvvm;
using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleA.ViewModels
{
    class ViewEmployeeViewModel : BindableBase
    {
        private ObservableCollection<Employee> _employees;
        public ObservableCollection<Employee> Employees
        {
            get { return _employees; }
            set { SetProperty(ref _employees, value); }
        }

        private IDataSource<Employee> dataSource;
        //private IMessageViewer _viewer;

        public ViewEmployeeViewModel()
	    {
            dataSource = new MemoryCache<Employee>();
          //  _viewer = new MessageViewer();

            _employees = new ObservableCollection<Employee>(dataSource.GetAllItems());
	    }

        private void Fill_Values(ObservableCollection<Employee> a, List<Employee> b)
        {
            foreach (var emp in b)
            {
                a.Add(emp);
            }
        }
    }
}
