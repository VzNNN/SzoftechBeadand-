using System.Collections.ObjectModel;
using WhereIsMyMoney.Models;

namespace WhereIsMyMoney.ViewModel
{
    public class SavesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Incomes { get; set; }
        public ObservableCollection<MoneyDTO> Outcomes { get; set; }
        private IncomeService InSrvc;
        private OutcomeService OutSrvc;
        public SavesViewModel()
        {
            InSrvc = new IncomeService();
            OutSrvc = new OutcomeService();
            loadIncomes();
            loadOutcomes();
        }

        private void loadIncomes()
        {
            Incomes = new ObservableCollection<MoneyDTO>(InSrvc.getIncomes());
        }

        private void loadOutcomes()
        {
            Outcomes = new ObservableCollection<MoneyDTO>(OutSrvc.getOutcomes());
        }
    }
}
