using FastFoodDelivery.BLL;
using FastFoodDelivery.BLL.Builders;

string[] burgers = { "Cheeseburger", "Double Bacon Burger", "Spicy Chicken Burger", "Veggie Burger (vegetarian)", "Grilled Portobello Burger (vegetarian)" };

string[] desserts = { "Chocolate Cake", "Vanilla Ice Cream Sundae", "Apple Pie", "Brownie", "Fruit Salad" };

string[] drinks = { "Cola", "Orange Juice", "Iced Tea", "Sparkling Water", "Milkshake" };

Order();

int[] ChooseMeal()
{
    Console.WriteLine("Welcome to FastFoodDelivery!");
    Console.WriteLine("Here are our burgers: ");

    for (int i = 1; i <= burgers.Length; i++)
    {
        Console.WriteLine($"{i}. {burgers[i - 1]} - ${(burgers[i - 1].Contains("(vegetarian)") ? 2.50 : 4.00):f2}");
    }
    Console.WriteLine($"{burgers.Length + 1}. None");

    Console.Write("Please choose a burger: ");
    int burgerIndex = int.Parse(Console.ReadLine());

    Console.WriteLine("Here are our desserts: ");

    for (int i = 1; i <= desserts.Length; i++)
    {
        Console.WriteLine($"{i}. {desserts[i - 1]} - $3.00");
    }
    Console.WriteLine($"{desserts.Length + 1}. None");

    Console.Write("Please choose a dessert: ");
    int dessertIndex = int.Parse(Console.ReadLine());

    Console.WriteLine("Here are our drinks: ");

    for (int i = 1; i <= drinks.Length; i++)
    {
        Console.WriteLine($"{i}. {drinks[i - 1]} - $2.50");
    }
    Console.WriteLine($"{drinks.Length + 1}. None");

    Console.Write("Please choose a drink: ");
    int drinkIndex = int.Parse(Console.ReadLine());

    return [burgerIndex, dessertIndex, drinkIndex];
}

void Order()
{
    IMealBuilder mealBuilder;

    int[] meal = ChooseMeal();

    string burger = meal[0] > burgers.Length ? "None" : burgers[meal[0] - 1];
    string dessert = meal[1] > desserts.Length ? "None" : desserts[meal[1] - 1];
    string drink = meal[2] > drinks.Length ? "None" : drinks[meal[2] - 1];

    if (burger.Contains("(vegetarian)"))
    {
        mealBuilder = new VegetarianMealBuilder();
    } 
    else
    {
        mealBuilder = new MeatMealBurger();
    }

    MealDirector director = new MealDirector(mealBuilder);
    director.ConstructMeal(burger, drink, dessert);

    Console.WriteLine(director.GetMeal());
}

