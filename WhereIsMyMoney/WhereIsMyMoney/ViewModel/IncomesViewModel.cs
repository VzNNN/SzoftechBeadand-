using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using WhereIsMyMoney.Models;
using WhereIsMyMoney.ViewModel.Base;

namespace WhereIsMyMoney.ViewModel
{
    public class IncomesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Incomes { get; set; }
        private IncomeService InSrvc;
        public MoneyDTO CurrentIncome { get; set; }
        public CommandManager addCommand { get; }
        public string Message { get; set; }
        public IncomesViewModel()
        {
            InSrvc = new IncomeService();
            loadIncomes();
            CurrentIncome = new MoneyDTO();
            addCommand = new CommandManager(Add);
        }

        private void loadIncomes()
        {
            Incomes = new ObservableCollection<MoneyDTO>(InSrvc.getIncomes());
        }

        public void Add()
        {
            try
            {
                var IsAdded = InSrvc.AddIncome(CurrentIncome);
                loadIncomes();
                if (IsAdded)
                    Message = "Income has saved successfully";
                else
                    Message = "Save operation failed";
            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                           eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }
    }
}

