using commercetools.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("relative")]
    public partial class CartDiscountValueRelativeDraft : CartDiscountValueDraft
    {
        public long Permyriad { get; set;}
        public CartDiscountValueRelativeDraft()
        { 
           this.Type = "relative";
        }
    }
}
