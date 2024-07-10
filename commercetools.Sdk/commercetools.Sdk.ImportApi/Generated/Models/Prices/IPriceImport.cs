using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Prices.PriceImport))]
    public partial interface IPriceImport : IImportResource
    {
        new string Key { get; set; }

        ITypedMoney Value { get; set; }

        string Country { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IChannelKeyReference Channel { get; set; }

        IDiscountedPrice Discounted { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        bool? Publish { get; set; }

        bool? Staged { get; set; }

        IList<IPriceTier> Tiers { get; set; }
        IEnumerable<IPriceTier> TiersEnumerable { set => Tiers = value.ToList(); }


        ICustom Custom { get; set; }

        IProductVariantKeyReference ProductVariant { get; set; }

        IProductKeyReference Product { get; set; }

    }
}
