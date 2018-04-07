using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nieruchomosci.Models.Interfaces
{
    public interface IAddressRepository
    {
        int AddAddress(Address address);
        Address GetAddress(int addressId);
    }
}
