using commercetools.Api.Generated.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Carts
{
    public interface IItemShippingDetails 
    {
        List<IItemShippingTarget> Targets { get; set;}
        
        bool Valid { get; set;}
    }
}
