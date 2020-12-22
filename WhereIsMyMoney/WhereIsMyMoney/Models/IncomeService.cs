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
                    IncomesDTOs.Add(new MoneyDTO { Value = (int)income.Value, Type = income.Type, Duration = (int)income.Duration });
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return IncomesDTOs;
        }

        public bool AddIncome(MoneyDTO income)
        {
            bool IsAdded = false;
            try
            {
                var inc = new Incomes();
                inc.Value = income.Value;
                inc.Type = income.Type.ToString();
                inc.Duration = income.Duration;

                IncomeEntities.Incomes.Add(inc);
                var NoOfRowsAffected = IncomeEntities.SaveChanges();
                IsAdded = NoOfRowsAffected > 0;
            }
            catch (SqlException ex)
            {

                throw ex;
            }

            return IsAdded;
        }
    }
}
