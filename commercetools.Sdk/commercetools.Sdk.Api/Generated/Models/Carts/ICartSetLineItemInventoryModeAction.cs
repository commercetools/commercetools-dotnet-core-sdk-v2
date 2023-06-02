using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartSetLineItemInventoryModeAction))]
    public partial interface ICartSetLineItemInventoryModeAction : ICartUpdateAction
    {
        string LineItemId { get; set; }

        IInventoryMode InventoryMode { get; set; }

    }
}
