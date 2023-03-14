using System.Collections;
using Proiect_csharp.Domain;

namespace Proiect_csharp.Repository
{
    public abstract class CompetitorRepository: Repository<int, Competitor>
    {
        public Competitor findOne(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable findAll()
        {
            throw new System.NotImplementedException();
        }

        public Competitor save(Competitor entity)
        {
            throw new System.NotImplementedException();
        }

        public Competitor delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Competitor update(Competitor entity)
        {
            throw new System.NotImplementedException();
        }
    }
}