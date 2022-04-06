using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.Prices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.Prices.PriceImport))]
    public partial interface IPriceImport : IImportResource
    {
        ITypedMoney Value { get; set; }

        string Country { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IChannelKeyReference Channel { get; set; }

        IDiscountedPrice Discounted { get; set; }

        bool? Publish { get; set; }

        List<IPriceTier> Tiers { get; set; }

        ICustom Custom { get; set; }

        IProductVariantKeyReference ProductVariant { get; set; }

        IProductKeyReference Product { get; set; }
    }
}
