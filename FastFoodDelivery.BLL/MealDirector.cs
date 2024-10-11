using FastFoodDelivery.BLL.Builders;
using FastFoodDelivery.BLL.Models;

namespace FastFoodDelivery.BLL
{
    public class MealDirector
    {
        private readonly IMealBuilder _mealBuilder;

        public MealDirector(IMealBuilder mealBuilder)
        {
            _mealBuilder = mealBuilder;
        }

        public void ConstructMeal(string burger, string drink, string dessert)
        {
            _mealBuilder.BuildBurger(burger);
            _mealBuilder.BuildDrink(drink);
            _mealBuilder.BuildDessert(dessert);
            _mealBuilder.BuildIsVegetarian();
            _mealBuilder.BuildPrice();
        }

        public Meal GetMeal()
        {
            return _mealBuilder.GetMeal();
        }
    }
}
