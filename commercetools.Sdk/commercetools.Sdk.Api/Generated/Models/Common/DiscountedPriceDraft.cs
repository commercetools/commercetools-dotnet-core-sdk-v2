using commercetools.Api.Models.Common;
using commercetools.Api.Models.ProductDiscounts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Common
{
    public partial class DiscountedPriceDraft : IDiscountedPriceDraft
    {
        public IMoney Value { get; set; }

        public IProductDiscountReference Discount { get; set; }
    }
}
