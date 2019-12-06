using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Lab3.Models
{
    public class StringRepository : IRepository
    {
        private List<string> list = new List<string>();
        public void Add(string str)
        {
            list.Add(str);
        }

        public void Clear()
        {
            list.Clear();
        }

        public void Remove(string str)
        {
            list.Remove(str);
        }

        public void RemoveAt(int index)
        {
            list.RemoveAt(index);
        }
    }
}