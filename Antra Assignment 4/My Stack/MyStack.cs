using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Stack
{
    public class MyStack<T> 
    {
        private List<T> MyT = new List<T>();
        
        public int Count()
        {
            return MyT.Count;
        }
        public T Pop()
        {
            T temp = MyT[MyT.Count - 1];
            MyT.RemoveAt(MyT.Count - 1);
            return temp;
        }
        public void Push(T obj)
        {
            MyT.Add(obj);
        }

    }
}
