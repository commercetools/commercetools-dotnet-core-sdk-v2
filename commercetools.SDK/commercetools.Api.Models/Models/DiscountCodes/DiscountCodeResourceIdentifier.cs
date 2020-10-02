using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("discount-code")]
    public partial class DiscountCodeResourceIdentifier : ResourceIdentifier
    {
        public DiscountCodeResourceIdentifier()
        { 
           this.TypeId = "discount-code";
        }
    }
}
