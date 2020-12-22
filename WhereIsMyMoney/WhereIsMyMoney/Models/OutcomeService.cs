using System;
using System.Collections.Generic;
using System.Linq;

namespace WhereIsMyMoney.Models
{
   public class OutcomeService
    {
        private WhereIsMyMoneyDBEntities OutcomeEntities;

        public OutcomeService()
        {
            OutcomeEntities = new WhereIsMyMoneyDBEntities();
        }

        public List<MoneyDTO> getOutcomes()
        {
            List<MoneyDTO> OutcomesDTOs = new List<MoneyDTO>();
            try
            {
                var outcomes = from outcome in OutcomeEntities.Outcomes
                              select outcome;

                foreach (var outcome in outcomes)
                    OutcomesDTOs.Add(new MoneyDTO { Value = (int)outcome.Value, Type = outcome.Type, Duration = (int)outcome.Duration });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return OutcomesDTOs;
        }
    }
}
