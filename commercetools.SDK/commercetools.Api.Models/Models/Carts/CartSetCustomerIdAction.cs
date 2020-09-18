using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomerId")]
    public class CartSetCustomerIdAction : CartUpdateAction
    {
        public string CustomerId { get; set;}
    }
}
