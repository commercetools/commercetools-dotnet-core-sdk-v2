using commercetools.Sdk.Api.Models.CartDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class DirectDiscount : IDirectDiscount
    {
        public string Id { get; set; }

        public ICartDiscountValue Value { get; set; }

        public ICartDiscountTarget Target { get; set; }
    }
}
