using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Box<T>
    {
        private T Item;



        public void Put(T item)
        {
            Item = item;
        }

        public T Get()
        {
            return Item;
        }

        public override string ToString()
        {
            return $"Предмет в коробке: {Item}";
        }
    }
}
