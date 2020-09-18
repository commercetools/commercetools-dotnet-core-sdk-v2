using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setCustomType")]
    public class DiscountCodeSetCustomTypeAction : DiscountCodeUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
    }
}
