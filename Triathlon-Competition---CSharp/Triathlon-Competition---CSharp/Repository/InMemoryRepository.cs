using System.Collections;
using Proiect_csharp.Domain;

namespace Proiect_csharp.Repository
{
    public abstract class InMemoryRepository: Repository<int, Contest>
    {
        public Contest findOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable findAll()
        {
            throw new System.NotImplementedException();
        }

        public Contest save(Contest entity)
        {
            throw new System.NotImplementedException();
        }

        public Contest delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Contest update(Contest entity)
        {
            throw new System.NotImplementedException();
        }
    }
}