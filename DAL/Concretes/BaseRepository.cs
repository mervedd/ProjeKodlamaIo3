using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
        public interface BaseRepository<T> where T : class
        {
            void Add(T entity);
            void Delete(int entity);
            void Update(T entity);
            List<T> GetAll();
            T GetById(int entityId);
    }
}
