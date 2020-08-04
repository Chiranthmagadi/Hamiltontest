using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Hamilton.Business.Interfaces;
using Hamilton.Models;

namespace Hamilton.Controllers
{
    [ApiController, Route("[controller]")]
    public class AddressBookController : ControllerBase
    {
        private readonly IAddressBookService addressBookService;
        public AddressBookController(IAddressBookService addressBookService)
        {
            this.addressBookService = addressBookService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(addressBookService.GetAddresses());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var address = addressBookService.GetAddress(id);
            if (address == null)
            {
                return NotFound();
            }
            return Ok(address);
        }

        [HttpPost]
        public IActionResult Create(AddressBook model)
        {
            if (model.DateOfBirth < DateTime.Now.Date)
            {

                var address = addressBookService.GetAddresses();
                bool addressExist = address.Any(x => x.Email == model.Email);
                if (addressExist)
                {
                    return BadRequest("Address already exist.");
                }
                var add = addressBookService.CreateAddress(model);
                return Created($"addressBook/{add.AddressBookId}", add);

            }
            else
            {
                return BadRequest("Date must be past date");
            }
        }
    }
}
