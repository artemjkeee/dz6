namespace dz2.Models
{
    struct Product
    {
        public string name;
        public int price;
        public int protein;
        public int fat;
        public int carb;

        public Product(string name, int price, int protein, int fat, int carb)
        {
            this.name = name;
            this.price = price;
            this.protein = protein;
            this.fat = fat;
            this.carb = carb;
        }
    }

    class Cart
    {
        private Product[] products = new Product[20];
        private int count = 0;

        public void AddProduct(Product p)
        {
            if (count < products.Length)
            {
                products[count] = p;
                count++;
            }
        }

        public int Total()
        {
            int total = 0;
            for (int i = 0; i < count; i++)
            {
                total += products[i].price;
            }
            return total;
        }

        public void ShowProducts()
        {
            Console.WriteLine("\nКорзина:");
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{products[i].name}  {products[i].price} грн | Б: {products[i].protein} Ж: {products[i].fat} В: {products[i].carb}");
            }
        }

        public void ShowNutritionSummary()
        {
            int totalProtein = 0;
            int totalFat = 0;
            int totalCarb = 0;

            for (int i = 0; i < count; i++)
            {
                totalProtein += products[i].protein;
                totalFat += products[i].fat;
                totalCarb += products[i].carb;
            }

            Console.WriteLine($"\nРазом: Білки={totalProtein}, Жири={totalFat}, Вуглеводи={totalCarb}");


            if (totalProtein > 200) Console.WriteLine(" Попередження: забагато білків!");
            if (totalFat > 150) Console.WriteLine(" Попередження: забагато жирів!");
            if (totalCarb > 300) Console.WriteLine(" Попередження: забагато вуглеводів!");
        }
    }
}