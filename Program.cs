using Shop;
using System.Runtime.CompilerServices;

List<Product> simplelist = new List<Product>();
simplelist.Add(new Product { Price = 1, Name = "Apple"});
simplelist.Add(new Product { Price = 2, Name = "Grape"});
simplelist.Add(new Product { Price = 3, Name = "Tomato"});

Product[] simpleArray = new Product[19];
simpleArray[0] = new Product { Price = 1, Name = "Apple" };
simpleArray[1] = new Product { Price = 2, Name = "Grape" };
simpleArray[2] = new Product { Price = 3, Name = "Tomato" };

int weight = Convert.ToInt32(Console.ReadLine());
string name = Console.ReadLine();
int balance = 1000;
Product? product = simplelist.Where(p => p.Name == name).FirstOrDefault();
balance += product.Price * weight;
Console.WriteLine("Итоговый баланс равен: " + balance);