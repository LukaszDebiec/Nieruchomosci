using Nieruchomosci.Models.Database;
using Nieruchomosci.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nieruchomosci.Models.Repositories
{
    public class OwnerRepository : IOwnerRepository
    {
        private readonly DatabaseContext _databaseContext;

        public OwnerRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }


        public int AddOwner(Owner owner)
        {
            if (owner == null)
            {
                throw new Exception("Owner field has to have something");
            }

            _databaseContext.Owners.Add(owner);
            _databaseContext.SaveChanges();
            return owner.OwnerId;

        }

        public Owner GetOwner(int ownerId)
        {
            if (ownerId <=0)
                {
                    throw new Exception("Owner ID cannot be equal or less than 0");
                }
            return _databaseContext.Owners.FirstOrDefault(o => o.OwnerId == ownerId);
        }
    }
}
