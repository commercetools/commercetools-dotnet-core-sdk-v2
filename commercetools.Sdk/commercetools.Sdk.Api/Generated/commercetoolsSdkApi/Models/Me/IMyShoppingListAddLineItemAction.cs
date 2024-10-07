using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListAddLineItemAction))]
    public partial interface IMyShoppingListAddLineItemAction : IMyShoppingListUpdateAction
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
