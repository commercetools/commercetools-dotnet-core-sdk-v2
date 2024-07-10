using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Orders
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Orders.LineItemPrice))]
    public partial interface ILineItemPrice
    {
        ITypedMoney Value { get; set; }

        string Country { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IChannelKeyReference Channel { get; set; }

        IDiscountedPrice Discounted { get; set; }

        IList<IPriceTier> Tiers { get; set; }
        IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        ICustom Custom { get; set; }

    }
}
