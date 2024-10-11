using FastFoodDelivery.BLL.Models;

namespace FastFoodDelivery.BLL.Builders
{
    public interface IMealBuilder
    {
        void BuildBurger(string burger);
        void BuildDrink(string drink);
        void BuildDessert(string dessert);
        void BuildIsVegetarian();
        void BuildPrice();
        Meal GetMeal();
    }
}
