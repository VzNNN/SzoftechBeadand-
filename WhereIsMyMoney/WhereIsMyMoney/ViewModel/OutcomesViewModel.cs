using System.Collections.ObjectModel;
using WhereIsMyMoney.Models;

namespace WhereIsMyMoney.ViewModel
{
    public class OutcomesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Outcomes { get; set; }
        private OutcomeService OutSrvc;
        public OutcomesViewModel()
        {
            OutSrvc = new OutcomeService();
            loadOutcomes();
        }

        private void loadOutcomes()
        {
            Outcomes = new ObservableCollection<MoneyDTO>(OutSrvc.getOutcomes());
        }
    }
}
