using System.Collections.Generic;
using System.Threading.Tasks;
using CustApp.API.Model;

namespace CustApp.API.Data
{
    public interface ICustRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int id);
    }
}