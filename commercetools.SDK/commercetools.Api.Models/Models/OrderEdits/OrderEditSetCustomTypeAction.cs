using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomType")]
    public class OrderEditSetCustomTypeAction : OrderEditUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
    }
}
