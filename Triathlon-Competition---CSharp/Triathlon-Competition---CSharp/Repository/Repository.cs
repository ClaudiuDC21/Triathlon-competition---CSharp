using System.Collections;
using System.Linq;
using Proiect_csharp.Domain;

namespace Proiect_csharp.Repository
{
    public interface Repository<in TId, TE> where TE : Entity<TId>
    {
        TE findOne(TId id);
        IEnumerable findAll();
        TE save(TE entity);
        TE delete(TId id);
        TE update(TE entity);
    }
}