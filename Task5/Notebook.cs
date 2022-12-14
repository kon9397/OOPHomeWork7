using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    internal struct Notebook
    {
        private string model;
        private string producer;
        private double price;

        public Notebook(string model, string producer, double price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void displayNotebookFields()
        {
            Console.WriteLine("Notebook details:");
            Console.WriteLine($"Model: {model}");
            Console.WriteLine($"Producer: {producer}");
            Console.WriteLine($"Price: {price}USD");
        }
    }
}
