namespace Session2.ADV
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region List
            //List<Product> catalog = new()
            //{
            //    new Product { Id=1, Name="Laptop", Category="Electronics", Price=1200, Stock=10 },
            //    new Product { Id=2, Name="Phone", Category="Electronics", Price=800, Stock=25 },
            //    new Product { Id=3, Name="T-Shirt", Category="Clothing", Price=30, Stock=100 },
            //    new Product { Id=4, Name="Jeans", Category="Clothing", Price=60, Stock=50 },
            //    new Product { Id=5, Name="Chocolate", Category="Food", Price=5, Stock=200 },
            //    new Product { Id=6, Name="Coffee Beans", Category="Food", Price=15, Stock=80 },
            //    new Product { Id=7, Name="C# Book", Category="Books", Price=45, Stock=30 },
            //    new Product { Id=8, Name="Novel", Category="Books", Price=20, Stock=60 },
            //    new Product { Id=9, Name="Headphones", Category="Electronics", Price=150, Stock=40 },
            //    new Product { Id=10, Name="Jacket", Category="Clothing", Price=120, Stock=15 }
            //};
            #endregion


            #region task 1
            //Console.WriteLine("--- Electronics ---");
            //var electronics = SearchProducts(catalog, p => p.Category == "Electronics");
            //foreach (var p in electronics)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");

            //Console.WriteLine("\n--- Under $50 ---");
            //var cheapProducts = SearchProducts(catalog, p => p.Price < 50);
            //foreach (var p in cheapProducts)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");


            //Console.WriteLine("\n--- In Stock ---");
            //var inStock = SearchProducts(catalog, p => p.Stock > 0);
            //foreach (var p in inStock)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");


            //Console.WriteLine("\n--- Clothing Under $100 ---");
            //var cheapClothing = SearchProducts(catalog, p => p.Category == "Clothing" && p.Price < 100);
            //foreach (var p in cheapClothing)
            //    Console.WriteLine($"{p.Name} - ${p.Price} (Stock: {p.Stock})");
            #endregion


            #region task 3
            //Console.WriteLine("\n--- Short Report ---");
            //PrintReport(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));

            //Console.WriteLine("\n--- Detailed Report ---");
            //PrintReport(catalog, p => Console.WriteLine($"[{p.Category}] {p.Name} | Price: ${p.Price} | Stock: {p.Stock}"));

            //Console.WriteLine("\n--- Summary List ---");
            //List<string> summaryList = TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
            //foreach (var item in summaryList)
            //    Console.WriteLine(item);

            //Console.WriteLine("\n--- Price Labels ---");
            //List<string> priceLabels = TransformProducts(catalog, p => $"{p.Name}: {(p.Price > 100 ? "Expensive!" : "Affordable")}");
            //foreach (var label in priceLabels)
            //    Console.WriteLine(label);


            //Console.WriteLine("\n--- Low-Stock Alert ---");
            //List<Product> lowStock = FilterProducts(catalog, p => p.Stock < 20);
            //foreach (var p in lowStock)
            //    Console.WriteLine($"[LOW STOCK] {p.Name}: only {p.Stock} left!");

            #endregion
        }

        #region Delegate methods
        //public static List<Product> SearchProducts(List<Product> products, Func<Product, bool> filter)
        //{

        //    List<Product> result = new List<Product>();
        //    foreach (var p in products)
        //    {
        //        if (filter(p))
        //        {
        //            result.Add(p);
        //        }
        //    }
        //    return result;

        //}


        //public static void PrintReport(List<Product> products, Action<Product> printAction)
        //{
        //    foreach (var p in products)
        //    {
        //        printAction(p);
        //    }
        //}


        //public static List<TResult> TransformProducts<TResult>(List<Product> products, Func<Product, TResult> transform)
        //{
        //    List<TResult> result = new List<TResult>();
        //    foreach (var p in products)
        //    {
        //        result.Add(transform(p));
        //    }
        //    return result;
        //}


        //public static List<Product> FilterProducts(List<Product> products, Predicate<Product> predicate)
        //{
        //    List<Product> result = new List<Product>();
        //    foreach (var p in products)
        //    {
        //        if (predicate(p))
        //        {
        //            result.Add(p);
        //        }
        //    }
        //    return result;
        //} 
        #endregion
    }
}

