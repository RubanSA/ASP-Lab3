using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Lab3.Models
{
    public class StringRepository<T> : IRepository<T>
    {
        public IList<T> List { get; set; } = new List<T>();
        public void Add(T str)
        {
            List.Add(str);
        }

        public void Clear()
        {
            List.Clear();
        }

        
        

        public void Remove(T item)
        {
            List.Remove(item);
        }

        

        public void RemoveAt(int index)
        {
            List.RemoveAt(index);
        }

        public IEnumerable<T> GetList()
        {
            return List;
        }
    }
}