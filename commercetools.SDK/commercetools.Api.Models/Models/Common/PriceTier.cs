using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class PriceTier 
    {
        public long MinimumQuantity { get; set;}
        
        public TypedMoney Value { get; set;}
    }
}
