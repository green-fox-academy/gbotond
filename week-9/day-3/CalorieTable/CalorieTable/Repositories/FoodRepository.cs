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

        public void AddFood(Food food)
        {
            FoodContext.Foods.Add(food);
            FoodContext.SaveChanges();
        }

        public Food GetId(long id)
        {
            return FoodContext.Foods.FirstOrDefault(f => f.Id == id);
        }

        public void Delete(long id)
        {
            FoodContext.Foods.Remove(GetId(id));
            FoodContext.SaveChanges();
        }

        //public Food GetFood()
        //{
        //    return FoodContext.Foods.FirstOrDefault();
        //}

        public void ChangeAmount(Food food)
        {
            FoodContext.Foods.Update(food);
            FoodContext.SaveChanges();
        }
    }
}
