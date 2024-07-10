using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.CartDiscounts
{

    public partial class CartDiscountValueRelative : ICartDiscountValueRelative
    {
        public string Type { get; set; }

        public long Permyriad { get; set; }
        public CartDiscountValueRelative()
        {
            this.Type = "relative";
        }
    }
}
