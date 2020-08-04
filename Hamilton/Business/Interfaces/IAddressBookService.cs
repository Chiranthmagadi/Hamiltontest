using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hamilton.Models;

namespace Hamilton.Business.Interfaces
{
   public interface IAddressBookService
    {
        AddressBook[] GetAddresses();

        AddressBook GetAddress(int adressId);

        AddressBook CreateAddress(AddressBook model);
    }
}
