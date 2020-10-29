using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    [DeserializeAs(typeof(commercetools.Api.Models.Common.PriceTier))]
    public interface IPriceTier 
    {
        long MinimumQuantity { get; set;}
        
        ITypedMoney Value { get; set;}
    }
}
