using commercetools.Api.Generated.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.DiscountCodes
{
    public interface IDiscountCodeUpdate 
    {
        long Version { get; set;}
        
        List<IDiscountCodeUpdateAction> Actions { get; set;}
    }
}
