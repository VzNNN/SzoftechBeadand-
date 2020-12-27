using System;
using System.Collections.ObjectModel;
using WhereIsMyMoney.Models;
using WhereIsMyMoney.Command;

namespace WhereIsMyMoney.ViewModel
{
    public class IncomesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Incomes { get; set; }
        public MoneyDTO CurrentIncome { get; set; }
        public CommandManager addCommand { get; }
        public string Message { get; set; }
        public int sum { get; set; }
        private IncomeService InSrvc;
        public IncomesViewModel()
        {
            InSrvc = new IncomeService();
            loadIncomes();
            loadTotal();
            CurrentIncome = new MoneyDTO();
            CurrentIncome.Duration = 1;
            addCommand = new CommandManager(Add);
        }

        private void loadIncomes()
        {
            Incomes = new ObservableCollection<MoneyDTO>(InSrvc.getIncomes());
        }

        private void loadTotal() 
        {
            sum = InSrvc.getTotalIncomes();
        }
        public void Add()
        {
            try
            {
                var IsAdded = InSrvc.addIncome(CurrentIncome);
                loadIncomes();
                if (IsAdded)
                    Message = "Income has saved successfully to the database";
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

