using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
                    OutcomesDTOs.Add(new MoneyDTO { Value = (int)outcome.Value, Type = outcome.Type, Duration = (int)outcome.Duration, Total=(int)outcome.Total});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return OutcomesDTOs;
        }

        public bool AddOutcome(MoneyDTO outcome)
        {
            bool IsAdded = false;
            try
            {
                var outc = new Outcomes();
                outc.Value = outcome.Value;
                outc.Type = outcome.Type;
                outc.Duration = outcome.Duration;
                outc.Total = outcome.Value * outcome.Duration;
                OutcomeEntities.Outcomes.Add(outc);
                var NoOfRowsAffected = OutcomeEntities.SaveChanges();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return IsAdded;
        }

        public int getTotalOutcomes()
        {
            List<MoneyDTO> TotalDTOs = new List<MoneyDTO>();
            int sum;
            try
            {
                var totals = from outcome in OutcomeEntities.Outcomes
                             select outcome.Total;

                foreach (var total in totals)
                    TotalDTOs.Add(new MoneyDTO { Total = (int)total.Value });
                sum = TotalDTOs.Sum(x => x.Total);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return sum;
        }
    }
}
