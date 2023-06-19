using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.ProductTypes;
using commercetools.Sdk.Api.Models.Products;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListLineItem))]
    public partial interface IShoppingListLineItem
    {
        DateTime AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        DateTime? DeactivatedAt { get; set; }

        string Id { get; set; }

        ILocalizedString Name { get; set; }

        string ProductId { get; set; }

        IProductTypeReference ProductType { get; set; }

        long Quantity { get; set; }

        long? VariantId { get; set; }

        IProductVariant Variant { get; set; }

        ILocalizedString ProductSlug { get; set; }

    }
}
