using dz2.Models;

Cart cart = new Cart();

while (true)
{
    Console.WriteLine("add tovar ( 'exit'): ");
    string name = Console.ReadLine();

    if (name.ToLower() == "exit")
        break;

    Console.Write("add price: ");
    int price = int.Parse(Console.ReadLine());

    Console.Write("add protein: ");
    int protein = int.Parse(Console.ReadLine());

    Console.Write("add fat: ");
    int fat = int.Parse(Console.ReadLine());

    Console.Write("add carb: ");
    int carb = int.Parse(Console.ReadLine());

    Product p = new Product(name, price, protein, fat, carb);
    cart.AddProduct(p);

    Console.WriteLine("add to korzina!\n");
}

cart.ShowProducts();
Console.WriteLine($"summ: {cart.Total()} grn");
cart.ShowNutritionSummary();
Console.WriteLine($"date: {DateTime.Now}"