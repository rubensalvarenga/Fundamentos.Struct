using System;

namespace Fundamentos.Structs
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Product mouse = new Product(1,"Mouse game","Produto Importado pela Microsoft", 299.34);
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Struct exemplo prático");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("-----------------------");
            Console.WriteLine("");
            Console.WriteLine("ID :"+mouse.Id);
            Console.WriteLine("Nome : "+mouse.Name);
            Console.WriteLine($"Descrição : {mouse.Description}");
            
            var formato = mouse.Price.ToString("C");
            Console.Write("VALOR PROMOCIONAL : ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(formato);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("");


        }
    }

    struct Product
    {
        public Product(int id, string name, string descripton, double price)
        {
            Id = id; //propriedade recebe o parametro
            Name = name;
            Price = price;
            Description = descripton;
        }

        public int Id;
        public string Name;
        public string Description;
        public double Price;

        public double PriceInDolar (double dolar)
        {
            return Price * dolar;
        }
    }
}
