using commercetools.Sdk.Api.Models.Carts;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.TaxCategories;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartAddCustomLineItemAction))]
    public partial interface ICartAddCustomLineItemAction : ICartUpdateAction
    {
        IMoney Money { get; set; }

        ILocalizedString Name { get; set; }

        string Key { get; set; }

        long? Quantity { get; set; }

        string Slug { get; set; }

        ITaxCategoryResourceIdentifier TaxCategory { get; set; }

        IExternalTaxRateDraft ExternalTaxRate { get; set; }

        IItemShippingDetailsDraft ShippingDetails { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        ICustomLineItemPriceMode PriceMode { get; set; }

    }
}
