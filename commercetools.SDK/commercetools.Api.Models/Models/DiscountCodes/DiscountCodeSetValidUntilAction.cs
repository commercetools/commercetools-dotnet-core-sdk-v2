using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("setValidUntil")]
    public class DiscountCodeSetValidUntilAction : DiscountCodeUpdateAction
    {
        public DateTime ValidUntil { get; set;}
    }
}
