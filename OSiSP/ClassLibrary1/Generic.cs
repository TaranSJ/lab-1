using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    //new generic test class for our lab
    public class Generic<T>
    {
        private T item;
        //add item of some type 
        public void Add(T item)
        {
            this.item = item;
        }
        //show item of some type
        public T GetItem()
        {
            return this.item;
        }
    }
}
