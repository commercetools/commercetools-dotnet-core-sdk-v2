using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public class ExternalLineItemTotalPrice 
    {
        public Money Price { get; set;}
        
        public Money TotalPrice { get; set;}
    }
}
