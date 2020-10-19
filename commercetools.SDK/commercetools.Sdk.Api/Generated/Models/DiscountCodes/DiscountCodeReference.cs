using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.DiscountCodes
{
    [DiscriminatorValue("discount-code")]
    public partial class DiscountCodeReference : Reference
    {
        public DiscountCode Obj { get; set;}
        public DiscountCodeReference()
        { 
           this.TypeId = "discount-code";
        }
    }
}
