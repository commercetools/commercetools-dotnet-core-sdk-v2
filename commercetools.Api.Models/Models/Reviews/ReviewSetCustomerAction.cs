using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Reviews
{
    public class ReviewSetCustomerAction : ReviewUpdateAction
    {
        public CustomerResourceIdentifier Customer { get; set;}
    }
}
