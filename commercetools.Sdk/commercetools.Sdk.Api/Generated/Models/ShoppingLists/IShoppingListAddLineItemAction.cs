using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.ShoppingLists.ShoppingListAddLineItemAction))]
    public partial interface IShoppingListAddLineItemAction : IShoppingListUpdateAction
    {
        string Key { get; set; }

        string Sku { get; set; }

        string ProductId { get; set; }

        long? VariantId { get; set; }

        long? Quantity { get; set; }

        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }

    }
}
