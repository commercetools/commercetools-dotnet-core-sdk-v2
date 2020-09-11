using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeSetCustomFieldAction : DiscountCodeUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
