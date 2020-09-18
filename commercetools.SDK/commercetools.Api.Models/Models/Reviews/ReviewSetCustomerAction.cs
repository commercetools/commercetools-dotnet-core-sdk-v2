using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setCustomer")]
    public class ReviewSetCustomerAction : ReviewUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
    }
}
