namespace FastFoodDelivery.BLL.Models
{
    public class Meal
    {
        public string Burger { get; set; }
        public string Drink { get; set; }
        public string Dessert { get; set; }
        public bool IsVegetarian { get; set; }
        public decimal Price { get; set; }

        public override string ToString() => 
            $"Your order: {(Burger == "None" ? "" : Burger + ", ")}" +
            $"{(Drink == "None" ? "" : Drink + ", ")}" +
            $"{(Dessert == "None" ? "" : Dessert + ", ")}" +
            $"{(IsVegetarian ? "Vegetarian meal" : "Not vegetarian meal")}, " +
            $"Total: ${Price}";
    }
}
