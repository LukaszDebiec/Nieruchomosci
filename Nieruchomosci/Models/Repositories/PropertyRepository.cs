using Nieruchomosci.Models.Database;
using Nieruchomosci.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nieruchomosci.Models.Repositories
{
    public class PropertyRepository : IPropertyRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PropertyRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;

        }
        public List<Property> GetAllProperties()
        {
            return _databaseContext.Properties.ToList();
        }

        public Property GetOneProperty( int propertyId)

        {
            if(propertyId <= 0)
            {
                throw new Exception("Sorry, but ID cannot be equal or less than 0");
            }


            return _databaseContext.Properties.Where(property => property.Id == propertyId).FirstOrDefault();
        }


        public int AddProperty(Property property, Address address, Owner owner)
        {
            if (property == null)
                throw new Exception("Property field must contain something!");
            if (address == null)
                throw new Exception("Address field must contain something!");
            if (owner == null)
                throw new Exception("Owner field must contain something!");

            property.Id = 0;
            property.Owner = owner;
            property.OwnerId = owner.OwnerId;

            property.Address = address;
            property.AddressId = address.AddressId;

            _databaseContext.Properties.Add(property);
            _databaseContext.SaveChanges();
            return property.Id;
        }

        public int UpdateProperty(Property property)
        {
            if (property == null)
                throw new Exception("Property field must contain something!");
            _databaseContext.Properties.Update(property);
            _databaseContext.SaveChanges();
            return property.Id;

        }

        public void DeleteProperty(Property property, Address address, Owner owner)
        {
            if (property == null)
                throw new Exception("Property field must contain something!");
            if (address == null)
                throw new Exception("Address field must contain something!");
            if (owner == null)
                throw new Exception("Owner field must contain something!");

            _databaseContext.Properties.Remove(property);
            _databaseContext.SaveChanges();
            _databaseContext.Addresses.Remove(address);
            _databaseContext.SaveChanges();
            _databaseContext.Owners.Remove(owner);
            _databaseContext.SaveChanges();
        }
    }
}
