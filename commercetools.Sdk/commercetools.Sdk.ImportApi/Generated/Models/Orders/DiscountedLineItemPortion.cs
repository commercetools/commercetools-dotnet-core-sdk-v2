using commercetools.Sdk.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.ImportApi.Models.Orders
{

    public partial class DiscountedLineItemPortion : IDiscountedLineItemPortion
    {
        public ICartDiscountKeyReference Discount { get; set; }

        public IMoney DiscountedAmount { get; set; }
    }
}
