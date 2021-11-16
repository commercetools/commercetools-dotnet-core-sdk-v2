using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListChangeLineItemQuantityAction))]
    public partial interface IMyShoppingListChangeLineItemQuantityAction : IMyShoppingListUpdateAction
    {
        string LineItemId { get; set;}
        
        long Quantity { get; set;}
    }
}
