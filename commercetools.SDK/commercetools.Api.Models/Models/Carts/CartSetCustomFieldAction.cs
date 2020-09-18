using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomField")]
    public class CartSetCustomFieldAction : CartUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
