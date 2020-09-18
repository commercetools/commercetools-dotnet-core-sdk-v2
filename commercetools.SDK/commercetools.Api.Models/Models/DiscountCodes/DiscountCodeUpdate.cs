using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    public class DiscountCodeUpdate 
    {
        public long Version { get; set;}
        
        public List<DiscountCodeUpdateAction> Actions { get; set;}
    }
}
