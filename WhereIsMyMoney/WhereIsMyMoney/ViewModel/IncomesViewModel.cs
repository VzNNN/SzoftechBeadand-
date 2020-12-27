using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using WhereIsMyMoney.Models;
using WhereIsMyMoney.Command;

namespace WhereIsMyMoney.ViewModel
{
    public class IncomesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Incomes { get; set; }
        private IncomeService InSrvc;
        public MoneyDTO CurrentIncome { get; set; }
        public CommandManager addCommand { get; }
        public string Message { get; set; }
        public int sum { get; set; }
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
                var IsAdded = InSrvc.AddIncome(CurrentIncome);
                loadIncomes();
                if (IsAdded)
                    Message = "Income has saved successfully to the database";
                else
                    Message = "Save operation failed";
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var error in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                           error.Entry.Entity.GetType().Name, error.Entry.State);
                    foreach (var err in error.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            err.PropertyName, err.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}

