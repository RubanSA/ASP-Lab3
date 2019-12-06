using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_Lab3.Models
{
    public interface IRepository
    {
        void Add(string str);
        void Remove(string str);
        void RemoveAt(int index);
        void Clear();
    }
}
