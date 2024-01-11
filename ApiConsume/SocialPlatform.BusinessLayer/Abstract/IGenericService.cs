using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialPlatform.BusinessLayer.Abstract
{
    public interface IGenericService<T> where T : class
    {
        // Inserts a new instance of T
        void TInsert(T t);
        // Deletes an instance of T
        void TDelete(T t);
        // Updates an existing instance of T
        void TUpdate(T t);
        // Retrieves a list of instances of T
        List<T> TGetList();
        // Retrieves an instance of T by its ID
        T TGetByID(int id);

    }
}
