using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WhereIsMyMoney.ViewModel;

namespace WhereIsMyMoney.Command
{
    public class UpdateViewCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private MainViewModel viewModel;
        public UpdateViewCommand(MainViewModel viewModel)
        {
            this.viewModel = viewModel;
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            
            if (parameter.ToString()=="Home")
            {
                viewModel.SelectedViewModel = new HomeViewModel();
            }
            else if (parameter.ToString() == "Incomes")
            {
                viewModel.SelectedViewModel = new IncomesViewModel();
            }
            else if (parameter.ToString() == "Outcomes")
            {
                viewModel.SelectedViewModel = new OutcomesViewModel();
            }
            else if (parameter.ToString() == "Saves")
            {
                viewModel.SelectedViewModel = new SavesViewModel();
            }
            else if (parameter.ToString() == "Graphs")
            {
                viewModel.SelectedViewModel = new GraphsViewModel();
            }
            else if (parameter.ToString() == "Exchanges")
            {
                viewModel.SelectedViewModel = new ExchangesViewModel();
            }
        }
    }
}
