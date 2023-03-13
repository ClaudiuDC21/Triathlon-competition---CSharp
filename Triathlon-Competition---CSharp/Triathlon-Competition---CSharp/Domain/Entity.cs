using System;

namespace Proiect_csharp.Domain
{
    public class Entity<TId>
    {

        public Guid Id
        {
            get => Id;
            set => Id = value;
        }
    }
}