using FastFoodDelivery.BLL.Models;

namespace FastFoodDelivery.BLL.Builders
{
    public class MeatMealBurger : IMealBuilder
    {
        private Meal meal = new Meal();

        public void BuildBurger(string burger)
        {
            meal.Burger = burger;
        }

        public void BuildDessert(string dessert)
        {
            meal.Dessert = dessert;
        }

        public void BuildDrink(string drink)
        {
            meal.Drink = drink;
        }

        public void BuildIsVegetarian()
        {
            meal.IsVegetarian = false;
        }

        public void BuildPrice()
        {
            decimal price = 0;

            if (meal.Burger != "None")
            {
                price += 4.00m;
            }

            if (meal.Dessert != "None")
            {
                price += 3.00m;
            }

            if (meal.Drink != "None")
            {
                price += 2.50m;
            }

            meal.Price = price;
        }

        public Meal GetMeal()
        {
            return meal;
        }
    }
}
