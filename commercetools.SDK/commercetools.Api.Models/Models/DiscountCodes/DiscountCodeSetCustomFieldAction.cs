using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setCustomField")]
    public class DiscountCodeSetCustomFieldAction : DiscountCodeUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
