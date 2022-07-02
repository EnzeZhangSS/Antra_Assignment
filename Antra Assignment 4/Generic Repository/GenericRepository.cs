using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Repository
{
    public class GenericRepository<T> : IRepository<T> where T : class, IRepository<T>
    {
        List<T> MyT = new List<T>();
        List<int> ActList = new List<int>();
        List<T> ActObj = new List<T>();


        public int Id { get; set; }

        public void Add(T item)
        {
            //MyT.Add(item);
            
            // Add has action number 1
            ActList.Add(1);
            ActObj.Add(item); 
        }

        public IEnumerable<T> GetAll()
        {
            return MyT;
        }

        public T GetById(int id)
        {
            foreach(T i in MyT)
            {
                if (i.Id == id)
                {
                    return i;
                }
            }
            return null;
        }

        public void Remove(T item)
        {
            //MyT.Remove(item);

            // Remove has action number 2
            ActList.Add(2);
            ActObj.Add(item); 
        }

        public void Save()
        {
            for(int j = 0; j < ActList.Count; j++)
            {
                if (ActList[j] == 1)
                {
                    MyT.Add(ActObj[j]);
                }
                else if (ActList[j] == 2)
                {
                    MyT.Remove(ActObj[j]);
                }
            }
            ActList.Clear();
            ActObj.Clear();
        }
    }
}
