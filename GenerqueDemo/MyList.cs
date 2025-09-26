using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerqueDemo
{
    public class MyList<T> 
    { 
        ArrayList list;
        public MyList()
        {
            list = new ArrayList(); 
        }
        public void Add(T item)  
        {   
                list.Add(item);            
        }

        public void Remove(T item)
        {
            if (list.Contains(item)) list.Remove(item);
            else throw new InvalidOperationException("Item n'existe pas");
        }

        public T Get(int index)
        {
            if (index > list.Count - 1 || index < 0) throw new IndexOutOfRangeException();
            return (T)list[index];
        }        
    }
}
