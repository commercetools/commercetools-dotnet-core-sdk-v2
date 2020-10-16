using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    [DiscriminatorValue("absolute")]
    public partial class CartDiscountValueAbsoluteDraft : CartDiscountValueDraft
    {
        public List<Money> Money { get; set;}
        public CartDiscountValueAbsoluteDraft()
        { 
           this.Type = "absolute";
        }
    }
}
