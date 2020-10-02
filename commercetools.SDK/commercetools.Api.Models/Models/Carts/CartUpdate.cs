using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public partial class CartUpdate 
    {
        public long Version { get; set;}
        
        public List<CartUpdateAction> Actions { get; set;}
    }
}
