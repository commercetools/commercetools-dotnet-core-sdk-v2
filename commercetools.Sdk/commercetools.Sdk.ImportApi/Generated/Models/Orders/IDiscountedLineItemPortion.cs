using commercetools.ImportApi.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.DiscountedLineItemPortion))]
    public partial interface IDiscountedLineItemPortion
    {
        ICartDiscountKeyReference Discount { get; set; }

        IMoney DiscountedAmount { get; set; }
    }
}
