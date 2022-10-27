using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        void Insert(List<T> theObject);
        void Delete(int index);
        void SaveChanges();
    }
}
