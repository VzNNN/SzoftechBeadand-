using System;
using System.Collections.ObjectModel;
using System.Data.Entity.Validation;
using WhereIsMyMoney.Models;
using WhereIsMyMoney.Command;

namespace WhereIsMyMoney.ViewModel
{
    public class OutcomesViewModel : BaseViewModel
    {
        public ObservableCollection<MoneyDTO> Outcomes { get; set; }
        private OutcomeService OutSrvc;
        public MoneyDTO CurrentOutcome { get; set; }
        public CommandManager addCommand { get; }
        public string Message { get; set; }
        public int sum { get; set; }
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
                var IsAdded = OutSrvc.AddOutcome(CurrentOutcome);
                loadOutcomes();
                if (IsAdded)
                    Message = "Outcome has saved successfully to the database";
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
