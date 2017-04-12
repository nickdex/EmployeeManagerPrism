using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class MemoryCache<T> : IDataSource<T>
    {
        private static Dictionary<int?, T> employees;

        public MemoryCache()
        {
            if (employees == null)
            {
                employees = new Dictionary<int?, T>();
            }
        }

        public void Add(int itemId, T item)
        {
            employees.Add(itemId, item);
        }

        public bool Delete(int itemId)
        {
            return employees.Remove(itemId);
        }

        public void Update(int itemId, T item)
        {
            employees[itemId] = item;
        }

        public T GetItem(int itemId)
        {
            return employees[itemId];
        }

        public List<T> GetAllItems()
        {
            var list = employees.ToList();
            return list.Select(o => o.Value).ToList();
        }
    }
}
