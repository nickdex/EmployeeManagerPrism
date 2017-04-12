using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public interface IDataSource<T>
    {
        void Add(int itemId, T item);
        bool Delete(int itemId);
        void Update(int itemId, T item);
        T GetItem(int itemId);
        List<T> GetAllItems();
    }
}
