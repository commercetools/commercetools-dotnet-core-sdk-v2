using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveLineItemAction))]
    public partial interface IMyShoppingListRemoveLineItemAction : IMyShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        string LineItemKey { get; set; }

        long? Quantity { get; set; }

    }
}
