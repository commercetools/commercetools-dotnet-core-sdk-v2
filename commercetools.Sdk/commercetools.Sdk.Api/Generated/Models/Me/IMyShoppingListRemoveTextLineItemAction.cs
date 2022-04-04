using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyShoppingListRemoveTextLineItemAction))]
    public partial interface IMyShoppingListRemoveTextLineItemAction : IMyShoppingListUpdateAction
    {
        string TextLineItemId { get; set; }

        long? Quantity { get; set; }
    }
}
