using commercetools.Sdk.ImportApi.Models.Common;
using commercetools.Sdk.ImportApi.Models.Customfields;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.ImportApi.Models.StandalonePrices
{
    [DeserializeAs(typeof(commercetools.Sdk.ImportApi.Models.StandalonePrices.StandalonePriceImport))]
    public partial interface IStandalonePriceImport : IImportResource
    {
        new string Key { get; set; }

        string Sku { get; set; }

        ITypedMoney Value { get; set; }

        string Country { get; set; }

        ICustomerGroupKeyReference CustomerGroup { get; set; }

        IChannelKeyReference Channel { get; set; }

        DateTime? ValidFrom { get; set; }

        DateTime? ValidUntil { get; set; }

        List<IPriceTier> Tiers { get; set; }

        IDiscountedPrice Discounted { get; set; }

        ICustom Custom { get; set; }

    }
}
