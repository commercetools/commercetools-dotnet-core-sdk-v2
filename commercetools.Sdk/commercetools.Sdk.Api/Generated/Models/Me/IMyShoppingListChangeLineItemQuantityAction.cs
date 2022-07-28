using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction))]
    public partial interface IMyShoppingListChangeLineItemQuantityAction : IMyShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        long Quantity { get; set; }

    }
}
