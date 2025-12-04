using SOLID.OCP;
using SOLID.OCP.After.Implementations;
using OldProductFilter = SOLID.OCP.Before.ProductFilter;
using NewProductFilter = SOLID.OCP.After.Implementations.ProductFilter;

namespace ConsoleApp
{
    public class OCP
    {
        public static void Run()
        {
            var apple = new Product("Apple", Color.Green, Size.Small);
            var tree = new Product("Tree", Color.Green, Size.Large);
            var house = new Product("House", Color.Blue, Size.Large);

            Product[] products = [apple, tree, house];

            // Before OCP
            Console.WriteLine("Green products (old):");
            foreach (var product in OldProductFilter.FilterByColor(products, Color.Green))
                Console.WriteLine($" - {product.Name} is green");

            // After OCP
            var newProductFilter = new NewProductFilter();
            Console.WriteLine("Green products (new):");
            foreach (var product in newProductFilter.Filter(products, new ColorSpecification(Color.Green)))
                Console.WriteLine($" - {product.Name} is green");

            Console.WriteLine("Large products");
            foreach (var product in newProductFilter.Filter(products, new SizeSpecification(Size.Large)))
                Console.WriteLine($" - {product.Name} is large");

            Console.WriteLine("Large blue items");
            foreach (var product in newProductFilter.Filter(products,
              new AndSpecification<Product>(new ColorSpecification(Color.Blue), new SizeSpecification(Size.Large)))
            )
            {
                Console.WriteLine($" - {product.Name} is big and blue");
            }
        }
    }
}
