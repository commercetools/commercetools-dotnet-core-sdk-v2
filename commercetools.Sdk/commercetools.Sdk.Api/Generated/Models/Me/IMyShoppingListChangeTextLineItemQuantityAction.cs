using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListChangeTextLineItemQuantityAction))]
    public partial interface IMyShoppingListChangeTextLineItemQuantityAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long Quantity { get; set; }
    }
}
