using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Productdrafts
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Productdrafts.PriceDraftImport))]
    public partial interface IPriceDraftImport
    {
        ITypedMoney Value { get; set; }

        string Country { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IChannelKeyReference Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ICustom Custom { get; set; }

        IDiscountedPrice Discounted { get; set; }

        IList<IPriceTier> Tiers { get; set; }

        IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }

        string Key { get; set; }

    }
}
