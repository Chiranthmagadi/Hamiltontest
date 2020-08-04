using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hamilton.Business.Interfaces;
using Hamilton.Models;

namespace Hamilton.Business
{

public class AddressBookService : IAddressBookService
    {
    private readonly AddressBookContext context;

    public AddressBookService(AddressBookContext context)
    {
        this.context = context;
    }

    public AddressBook CreateAddress(AddressBook model)
    {
        var addAddress = context.AddressBooks.Add(new AddressBook
        {
             FirstName=model.FirstName,
             SurName = model.SurName,
             DateOfBirth=model.DateOfBirth,
             Email = model.Email
        });

        context.SaveChanges();

        return new AddressBook
        {
            AddressBookId = addAddress.Entity.AddressBookId,
            FirstName = addAddress.Entity.FirstName,
            SurName = addAddress.Entity.SurName,
            DateOfBirth = addAddress.Entity.DateOfBirth,
            Email = addAddress.Entity.Email

        };
    }

    public AddressBook GetAddress(int addressId)
    {
        return context.AddressBooks.Where(x => x.AddressBookId == addressId).Select(x => new AddressBook
        {
            AddressBookId = x.AddressBookId,
            FirstName = x.FirstName,
            SurName = x.SurName,
            DateOfBirth = x.DateOfBirth,
            Email = x.Email
        }).SingleOrDefault();
    }

    public AddressBook[] GetAddresses()
    {
        return context.AddressBooks.Select(x => new AddressBook
        {
            AddressBookId = x.AddressBookId,
            FirstName = x.FirstName,
            SurName = x.SurName,
            DateOfBirth = x.DateOfBirth,
            Email = x.Email
        }).ToArray();
    }
      
    }
}
