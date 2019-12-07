using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_Lab3.Models
{
    public interface IRepository<T>
    {
        void Add(T item);
        void Remove(T item);
        void RemoveAt(int index);
        void Clear();
        IEnumerable<T> GetList();
        IList<T> List { get; set; }
    }
}
