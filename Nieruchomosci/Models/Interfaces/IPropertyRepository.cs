using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nieruchomosci.Models.Interfaces
{
    public interface IPropertyRepository
    {
        List<Property> GetAllProperties();
        Property GetOneProperty(int propertyId);
        int AddProperty(Property property, Address address, Owner owner);
        int UpdateProperty(Property property);
        void DeleteProperty(Property property, Address address, Owner owner);
    }

}
