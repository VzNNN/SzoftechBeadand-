using System;
using System.Collections.ObjectModel;
using WhereIsMyMoney.Models;
using WhereIsMyMoney.Command;

namespace WhereIsMyMoney.ViewModel
{
    public class OutcomesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Outcomes { get; set; }
        public MoneyDTO CurrentOutcome { get; set; }
        public CommandManager addCommand { get; }
        public string Message { get; set; }
        public int sum { get; set; }
        private OutcomeService OutSrvc;
        public OutcomesViewModel()
        {
            OutSrvc = new OutcomeService();
            loadOutcomes();
            loadTotal();
            CurrentOutcome = new MoneyDTO();
            CurrentOutcome.Duration = 1;
            addCommand = new CommandManager(Add);
        }

        private void loadOutcomes()
        {
            Outcomes = new ObservableCollection<MoneyDTO>(OutSrvc.getOutcomes());
        }

        private void loadTotal()
        {
            sum = OutSrvc.getTotalOutcomes();
        }

        public void Add()
        {
            try
            {
                var IsAdded = OutSrvc.addOutcome(CurrentOutcome);
                loadOutcomes();
                if (IsAdded)
                    Message = "Outcome has saved successfully to the database";
                else
                    Message = "Save operation failed";
            }
            catch (Exception ex)
            {
                Message = ex.Message;
            }
        }


    }
}
