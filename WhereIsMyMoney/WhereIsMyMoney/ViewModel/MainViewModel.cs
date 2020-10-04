using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WhereIsMyMoney.Command;

namespace WhereIsMyMoney.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        private BaseViewModel _selectedViewModel = new ViewModel.HomeViewModel();
        public MainViewModel()
        {
            UpdateViewCommand = new UpdateViewCommand(this);
        }
        public BaseViewModel SelectedViewModel
        {
            get { return _selectedViewModel; }
            set { _selectedViewModel = value; }
        }
        public ICommand UpdateViewCommand { get; set; }
        
    }
}
