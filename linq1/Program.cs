using System;
using System.Collections.Generic;
using System.Linq;

namespace linq1
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string Category { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
    }

    public class Order
    {
        public int OrderID { get; set; }
        public int CustomerID { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime OrderDate { get; set; }
    }

    public class Customer
    {
        public int CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string Country { get; set; }
        public List<Order> Orders { get; set; }
    }

    internal class Program
    {
        static List<Product> ProductList = new List<Product>
        {
            new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.00m, UnitsInStock = 39 },
            new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.00m, UnitsInStock = 17 },
            new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.00m, UnitsInStock = 13 },
            new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.00m, UnitsInStock = 53 },
            new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.35m, UnitsInStock = 0 },
            new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.00m, UnitsInStock = 120 },
            new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.00m, UnitsInStock = 15 },
            new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.00m, UnitsInStock = 6 },
            new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.00m, UnitsInStock = 29 },
            new Product { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.00m, UnitsInStock = 31 },
            new Product { ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy", UnitPrice = 21.00m, UnitsInStock = 22 },
            new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy", UnitPrice = 38.00m, UnitsInStock = 86 },
            new Product { ProductID = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.00m, UnitsInStock = 24 },
            new Product { ProductID = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.25m, UnitsInStock = 35 },
            new Product { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.50m, UnitsInStock = 39 },
            new Product { ProductID = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.45m, UnitsInStock = 29 },
            new Product { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.00m, UnitsInStock = 0 },
            new Product { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.50m, UnitsInStock = 42 },
            new Product { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections", UnitPrice = 9.20m, UnitsInStock = 25 },
            new Product { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.00m, UnitsInStock = 40 }
        };

        static List<Customer> Customers = new List<Customer>
        {
            new Customer
            {
                CustomerID = 1,
                CompanyName = "Alfreds Futterkiste",
                Country = "Germany",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1001, CustomerID = 1, TotalValue = 500m, OrderDate = new DateTime(1997, 1, 15) },
                    new Order { OrderID = 1002, CustomerID = 1, TotalValue = 150m, OrderDate = new DateTime(1996, 5, 20) }
                }
            },

            new Customer
            {
                CustomerID = 2,
                CompanyName = "Ana Trujillo Emparedados",
                Country = "Mexico",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1003, CustomerID = 2, TotalValue = 300m, OrderDate = new DateTime(1998, 3, 10) }
                }
            },

            new Customer
            {
                CustomerID = 3,
                CompanyName = "Antonio Moreno Taqueria",
                Country = "Mexico",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1004, CustomerID = 3, TotalValue = 200m, OrderDate = new DateTime(1996, 11, 2) },
                    new Order { OrderID = 1005, CustomerID = 3, TotalValue = 100m, OrderDate = new DateTime(1997, 8, 22) }
                }
            },

            new Customer
            {
                CustomerID = 4,
                CompanyName = "Around the Horn",
                Country = "UK",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1006, CustomerID = 4, TotalValue = 400m, OrderDate = new DateTime(1997, 12, 5) }
                }
            },

            new Customer
            {
                CustomerID = 5,
                CompanyName = "Berglunds snabbkop",
                Country = "Sweden",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1007, CustomerID = 5, TotalValue = 250m, OrderDate = new DateTime(1995, 4, 18) },
                    new Order { OrderID = 1008, CustomerID = 5, TotalValue = 250m, OrderDate = new DateTime(1999, 1, 30) }
                }
            },

            new Customer
            {
                CustomerID = 6,
                CompanyName = "Blauer See Delikatessen",
                Country = "Germany",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1009, CustomerID = 6, TotalValue = 600m, OrderDate = new DateTime(1997, 6, 14) }
                }
            },

            new Customer
            {
                CustomerID = 7,
                CompanyName = "Blondel pere et fils",
                Country = "France",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1010, CustomerID = 7, TotalValue = 150m, OrderDate = new DateTime(1996, 9, 1) }
                }
            },

            new Customer
            {
                CustomerID = 8,
                CompanyName = "Bolido Comidas preparadas",
                Country = "Spain",
                Orders = new List<Order>
                {
                    new Order { OrderID = 1011, CustomerID = 8, TotalValue = 100m, OrderDate = new DateTime(1997, 2, 11) },
                    new Order { OrderID = 1012, CustomerID = 8, TotalValue = 100m, OrderDate = new DateTime(1998, 7, 19) },
                    new Order { OrderID = 1013, CustomerID = 8, TotalValue = 100m, OrderDate = new DateTime(1996, 12, 25) }
                }
            }
        };

        static void Main(string[] args)
        {
            #region Question 1
            //var q1 = ProductList.Where(p => p.Category == "Seafood");

            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            //}
            #endregion

            #region Question 2
            //var q2 = ProductList.Select(p => p.ProductName);

            //foreach (var name in q2)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region Question 3
            var q3 = ProductList.OrderBy(p => p.UnitPrice);

            foreach (var item in q3)
            {
                Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            }
            #endregion

            #region Question 4
            var q4 = ProductList.Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            foreach (var item in q4)
            {
                Console.WriteLine($"Name: {item.ProductName}, Price: {item.UnitPrice}");
            }
            #endregion

            #region Question 5
            var q5 = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            foreach (var item in q5)
            {
                Console.WriteLine($"Name: {item.ProductName}, Stock: {item.UnitsInStock}");
            }
            #endregion

            #region Question 6
            var q6 = ProductList.Select(p => new
            {
                Name = p.ProductName,
                Price = p.UnitPrice,
                StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            });

            foreach (var item in q6)
            {
                Console.WriteLine($"Name: {item.Name}, Price: {item.Price}, StockStatus: {item.StockStatus}");
            }
            #endregion

            #region Question 7
            var q7 = ProductList.Select((p, index) => $"{index + 1}. {p.ProductName}");

            foreach (var item in q7)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Question 8
            var q8 = ProductList
                .OrderBy(p => p.Category)
                .ThenByDescending(p => p.UnitPrice);

            foreach (var item in q8)
            {
                Console.WriteLine($"Category: {item.Category}, Price: {item.UnitPrice}, Name: {item.ProductName}");
            }
            #endregion

            #region Question 9
            var q9 = ProductList
                .Where(p => p.Category == "Beverages")
                .OrderByDescending(p => p.UnitsInStock);

            foreach (var item in q9)
            {
                Console.WriteLine($"Name: {item.ProductName}, Stock: {item.UnitsInStock}");
            }
            #endregion

            #region Question 10
            var q10 =
                from c in Customers
                from o in c.Orders
                where o.OrderDate.Year >= 1997
                select new
                {
                    CustomerID = o.CustomerID,
                    OrderDate = o.OrderDate
                };

            foreach (var item in q10)
            {
                Console.WriteLine($"CustomerID: {item.CustomerID}, OrderDate: {item.OrderDate:yyyy-MM-dd}");
            }
            #endregion

            #region Question 11
            var q11 = ProductList.Select((p, index) => new
            {
                Position = index + 1,
                ProductName = p.ProductName
            });

            foreach (var item in q11)
            {
                Console.WriteLine($"Position: {item.Position}, ProductName: {item.ProductName}");
            }
            #endregion

            #region Question 12
            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var q12 = Arr
                .OrderBy(w => w.Length)
                .ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            foreach (var word in q12)
            {
                Console.WriteLine(word);
            }
            #endregion

            #region Question 13
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var q13 = digits
                .Where(d => d.Length > 1 && d[1] == 'i')
                .Reverse();

            foreach (var digit in q13)
            {
                Console.WriteLine(digit);
            }
            #endregion
        }
    }
}