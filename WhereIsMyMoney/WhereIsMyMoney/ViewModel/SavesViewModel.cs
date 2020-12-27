using System.Collections.ObjectModel;
using WhereIsMyMoney.Models;
using WhereIsMyMoney.Command;

namespace WhereIsMyMoney.ViewModel
{
    public class SavesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Incomes { get; set; }
        public ObservableCollection<MoneyDTO> Outcomes { get; set; }
        public CommandManager calculateCommand { get; }
        private IncomeService InSrvc;
        private OutcomeService OutSrvc;
        public int MyMoney { get; set; }
        public SavesViewModel()
        {
            InSrvc = new IncomeService();
            OutSrvc = new OutcomeService();
            loadIncomes();
            loadOutcomes();
            calculateCommand = new CommandManager(loadTotal);
        }
        private void loadIncomes()
        {
            Incomes = new ObservableCollection<MoneyDTO>(InSrvc.getIncomes());
        }

        private void loadOutcomes()
        {
            Outcomes = new ObservableCollection<MoneyDTO>(OutSrvc.getOutcomes());
        }

        private void loadTotal()
        {
            MyMoney += InSrvc.getTotalIncomes();
            MyMoney -= OutSrvc.getTotalOutcomes();
        }

    }
}
