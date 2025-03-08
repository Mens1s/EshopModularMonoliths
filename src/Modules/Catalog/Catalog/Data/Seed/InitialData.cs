namespace Catalog.Data.Seed;
public static class InitialData
{
    public static IEnumerable<Product> Products =>
        new List<Product>
        {
            Product.Create(Guid.NewGuid(), "Iphone 15", new List<string> { "Telephone" }, "Apple new iphone a15", "product1.jpg", 100),
            Product.Create(Guid.NewGuid(), "Samsung Galaxy", new List<string> { "Telephone" }, "Samsung new galaxy s22", "product2.jpg", 200),
            Product.Create(Guid.NewGuid(), "Xiaomi Redmi", new List<string> { "Telephone" }, "Xiaomi new redmi note 11", "product3.jpg", 300),
            Product.Create(Guid.NewGuid(), "OnePlus", new List<string> { "Computer" }, "OnePlus new oneplus 10", "product4.jpg", 400),
        };
}

