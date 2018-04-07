using Nieruchomosci.Models.Database;
using Nieruchomosci.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nieruchomosci.Models.Repositories
{
    public class AddressRepository : IAddressRepository
    {
        private readonly DatabaseContext _databaseContext;

        public AddressRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public int AddAddress(Address address)
        {
            if( address == null)
            {
                throw new Exception("Address field has to have something");
            }

            _databaseContext.Addresses.Add(address);
            _databaseContext.SaveChanges();
            return address.AddressId;
        }

        public Address GetAddress(int addressId)
        {
           if(addressId <= 0)
            {
                throw new Exception("Address ID cannot be equal or lower than 0");
            }
            return _databaseContext.Addresses.FirstOrDefault(a => a.AddressId == addressId);
        }
    }
}
