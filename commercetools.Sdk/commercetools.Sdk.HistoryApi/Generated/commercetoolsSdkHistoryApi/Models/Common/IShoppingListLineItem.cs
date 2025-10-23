using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.HistoryApi.Models.Common
{
    [DeserializeAs(typeof(commercetools.Sdk.HistoryApi.Models.Common.ShoppingListLineItem))]
    public partial interface IShoppingListLineItem
    {
        DateTime AddedAt { get; set; }

        ICustomFields Custom { get; set; }

        DateTime? DeactivatedAt { get; set; }

        string Id { get; set; }

        string Key { get; set; }

        ILocalizedString Name { get; set; }

        string ProductId { get; set; }

        IProductTypeReference ProductType { get; set; }

        bool Published { get; set; }

        long Quantity { get; set; }

        long? VariantId { get; set; }

        IProductVariant Variant { get; set; }

        ILocalizedString ProductSlug { get; set; }

    }
}
