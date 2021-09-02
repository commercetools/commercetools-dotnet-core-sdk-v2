using commercetools.Api.Models.CartDiscounts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.CartDiscounts
{
    public partial class CartDiscountValueFixedDraft : ICartDiscountValueFixedDraft
    {
        public string Type { get; set; }

        public List<IMoney> Money { get; set; }
        public CartDiscountValueFixedDraft()
        {
            this.Type = "fixed";
        }
    }
}
