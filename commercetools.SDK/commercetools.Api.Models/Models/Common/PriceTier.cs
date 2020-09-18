using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public class PriceTier 
    {
        public long MinimumQuantity { get; set;}
        
        public TypedMoney Value { get; set;}
    }
}
