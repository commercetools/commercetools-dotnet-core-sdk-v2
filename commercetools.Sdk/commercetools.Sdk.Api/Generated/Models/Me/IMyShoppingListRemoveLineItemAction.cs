using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyShoppingListRemoveLineItemAction))]
    public partial interface IMyShoppingListRemoveLineItemAction : IMyShoppingListUpdateAction
    {
        string LineItemId { get; set; }

        long? Quantity { get; set; }
    }
}
