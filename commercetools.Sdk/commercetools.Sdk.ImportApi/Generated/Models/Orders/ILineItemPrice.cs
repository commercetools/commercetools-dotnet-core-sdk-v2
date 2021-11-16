using commercetools.ImportApi.Models.Common;
using commercetools.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.ImportApi.Models.Orders.LineItemPrice))]
    public partial interface ILineItemPrice
    {
        ITypedMoney Value { get; set; }

        string Country { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IChannelKeyReference Channel { get; set; }

        IDiscountedPrice Discounted { get; set; }

        List<IPriceTier> Tiers { get; set; }

        ICustom Custom { get; set; }
    }
}
