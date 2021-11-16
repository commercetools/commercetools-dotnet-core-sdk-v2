using commercetools.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.ShoppingLists
{
    [DeserializeAs(typeof(commercetools.Api.Models.ShoppingLists.ShoppingListLineItemDraft))]
    public partial interface IShoppingListLineItemDraft
    {
        DateTime? AddedAt { get; set; }

        ICustomFieldsDraft Custom { get; set; }

        string Sku { get; set; }

        string ProductId { get; set; }

        int? Quantity { get; set; }

        long? VariantId { get; set; }
    }
}
