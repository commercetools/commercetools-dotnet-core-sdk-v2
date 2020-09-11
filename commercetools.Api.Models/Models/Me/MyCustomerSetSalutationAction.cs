using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCustomerSetSalutationAction : MyCustomerUpdateAction
    {
        public string Salutation { get; set;}
    }
}
