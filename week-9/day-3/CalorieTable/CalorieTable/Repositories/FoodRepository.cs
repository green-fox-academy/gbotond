using CalorieTable.Entities;
using CalorieTable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalorieTable.Repositories
{
    public class FoodRepository
    {
        FoodContext FoodContext;

        public FoodRepository(FoodContext foodContext)
        {
            this.FoodContext = foodContext;
        }

        public List<Food> GetList()
        {
            return FoodContext.Foods.ToList();
        }
    }
}
