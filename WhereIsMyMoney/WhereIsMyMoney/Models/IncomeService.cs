using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace WhereIsMyMoney.Models
{
   public class IncomeService
    {
        WhereIsMyMoneyDBEntities IncomeEntities;
        public IncomeService()
        {
            IncomeEntities = new WhereIsMyMoneyDBEntities();
        }

        public List<MoneyDTO> getIncomes()
        {
            List<MoneyDTO> IncomesDTOs = new List<MoneyDTO>();
            try
            {
                var incomes = from income in IncomeEntities.Incomes
                               select income;

                foreach (var income in incomes)
                    IncomesDTOs.Add(new MoneyDTO { Value = (int)income.Value, Type = income.Type, Duration = (int)income.Duration, Total = (int)income.Total});
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IncomesDTOs;
        }

        public bool addIncome(MoneyDTO income)
        {
            bool IsAdded = false;

            if (income.Value.Equals(0) || income.Value.Equals(""))
            {
                throw new ArgumentException("You haven't typed anything in the value field.");
            }
            else if (income.Value < 1000)
            {
                throw new ArgumentException("Income value must be at least 1000.");
            }

            try
            {
                var inc = new Incomes();
                inc.Value = income.Value;
                inc.Type = income.Type;
                inc.Duration = income.Duration;
                inc.Total = income.Value * income.Duration;
                IncomeEntities.Incomes.Add(inc);
                var NoOfRowsAffected = IncomeEntities.SaveChanges();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return IsAdded;
        }

        public int getTotalIncomes()
        {
            List<MoneyDTO> TotalDTOs = new List<MoneyDTO>();
            int sum;
            try
            {
                var totals = from income in IncomeEntities.Incomes
                              select income.Total;

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
