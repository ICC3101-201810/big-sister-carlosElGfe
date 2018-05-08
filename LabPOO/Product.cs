using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabPOO
{
    class Product
    {
        private string name;
        private int stock;
        private int price; //Price for one unit of the product
        private string unit;

        public Product(string name, int price, int stock, string unit)
        {
            this.name = name;
            this.stock = stock;
            this.price = price;
            this.unit = unit;
        }
        public void suscribe()
        {
            yachekeado += new Chekeoprevioainsertar(enproductonoenlista);
        }
        public delegate void Chekeoprevioainsertar(List<Product> carrito, List<Product> lista);
        public event Chekeoprevioainsertar yachekeado;
        public virtual void enproductonoenlista(List<Product> carrito, List<Product> lista)
        {
            if (lista.Contains(this))
            {
               
            }
            else
            {
                carrito.Remove(this);
            }
          
        }
        public bool Agregar(List<Product> carrito, List<Product> lista)
        {
            if (stock > 0)
            {
                
                carrito.Add(this);
                stock--;
                return true;
            }
            return false;
        }

        public string Name { get => name; }
        public int Stock { get => stock; }
        public int Price { get => price; }
        public string Unit { get => unit; }
    }
}
