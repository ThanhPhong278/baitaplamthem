using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Book
    {
        private string Name;
        private Author[] Authors;
        private Double Price;
        private int Qty;

        public Book(string name, Author[] authors, Double price )
        {
            this.Name = name;
            this.Authors = authors;
            this.Price = price;
            this.Qty = 0;
        }
        public Book(string name, Author[] authors, Double price, int qty)
            :this(name,authors,price)
        {
            this.Qty = qty;
        }
        public string GetName() { return this.Name; }
        public Author[] GetAuthor() { return this.Authors; }
        public Double GetPrice() { return this.Price; }
        public int GetQty() { return this.Qty; }
        public void SetPrice(Double price) { this.Price = price; }
        public void SetQty(int qty) { this.Qty = qty; }
        public override string ToString()
        {
            string authors = "";
            for (int i = 0; i < this.Authors.Length; i++)
                authors += this.Authors[i].ToString() + " , ";
                return string.Format("Book [Name={0},{3}, authors={{{3}}},price={1},Qty={2}]",
                    this.Name, this.Price, this.Qty, authors);
            
        }
    }
}
