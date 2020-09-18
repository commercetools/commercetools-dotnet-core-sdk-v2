using commercetools.Api.Models.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Customers
{
    [DiscriminatorValue("setDateOfBirth")]
    public class CustomerSetDateOfBirthAction : CustomerUpdateAction
    {
        public DateTime DateOfBirth { get; set;}
    }
}
