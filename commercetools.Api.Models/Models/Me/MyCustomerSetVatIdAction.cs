using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyCustomerSetVatIdAction : MyCustomerUpdateAction
    {
        public string VatId { get; set;}
    }
}
