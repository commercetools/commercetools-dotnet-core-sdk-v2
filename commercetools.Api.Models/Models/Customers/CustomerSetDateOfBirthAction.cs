using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Customers
{
    public class CustomerSetDateOfBirthAction : CustomerUpdateAction
    {
        public DateTime DateOfBirth { get; set;}
    }
}
