using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    class RoundTable<T> : IEnumerable<T> where T : IComparable<T>
    {
        List<T> items = new List<T>();





        public void Add(T c)
        {
            
          
            items.Add(c);
            
        }

        public void RemoveAt(int d)
        {
            if (items.Count >= d)
            {
                this.items.RemoveAt(d);
            }
            else 
            {
                this.items.RemoveAt(d - items.Count - 1);
            }
        }

        public void InsertAt(int d, T a)
        {
            if (items.Count >= d)
            {
                this.items.Insert(d, a);
            }
            else 
            {
                this.items.Insert(d - items.Count - 1, a);
            }
        }

        public void Sort()
        {
            this.items.Sort();
        }

        public IEnumerator<T> GetEnumerator()
        {
            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return items.GetEnumerator();
        }

    

        //public List<T> GetRounded(int d)
        //{
        //    List<T> newList = new List<T>();
        //    int x = (d - items.Count - 1);
        //    if (items.Count >= d)
        //    {
        //        return items;
        //    }
        //    else
        //    {
        //        return x;
        //    }
         
           
        //}


        public T this[int index]
        {
            get
            {
                int d = 0;
                if (items.Count > index)
                {
                    return items[d];
                }
                else
                {
                    return items[index - items.Count - 1];
                }
            }

        }

        public T this[string name]
        {
            get
            {
                foreach (T item in items)
                {
                    if (item.ToString() == name)
                    {
                        return item;
                    }
                }
                return default(T);
            }
        }


        public override string ToString()
        {
            string result = "";
            foreach (T item in items)
            {
                result = result + $"{item}\n";
            }
            return result;
        }


    }
}
