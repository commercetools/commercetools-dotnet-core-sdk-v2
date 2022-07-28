using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction))]
    public partial interface IMyShoppingListChangeTextLineItemQuantityAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long Quantity { get; set; }

    }
}
