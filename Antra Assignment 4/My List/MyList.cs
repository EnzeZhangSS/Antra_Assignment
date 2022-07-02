using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_List
{
    public class MyList<T>
    {
        private List<T> MyL = new List<T>();

        public void Add(T element)
        {
            MyL.Add(element);
        }
        public T Remove(int index)
        {
            T temp = MyL[index];
            MyL.RemoveAt(index);
            return temp;
        }
        public bool Contains(T element)
        {
            return MyL.Contains(element);
        }
        public void Clear()
        {
            MyL.Clear();
        }
        public void InsertAt(T element, int index)
        {
            MyL.Insert(index, element);
        }
        public void DeleteAt(int index)
        {
            MyL.RemoveAt(index);
        }
        public T Find(int index)
        {
            return MyL[index];
        }
    }
}
