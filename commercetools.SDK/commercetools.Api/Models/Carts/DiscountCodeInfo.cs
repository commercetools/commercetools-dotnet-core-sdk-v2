using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Carts
{
    public partial class DiscountCodeInfo 
    {
        public DiscountCodeReference DiscountCode { get; set;}
        
        public string State { get; set;}
        
        [JsonIgnore]
        public DiscountCodeState StateAsEnum => this.State.GetEnum<DiscountCodeState>();
    }
}
