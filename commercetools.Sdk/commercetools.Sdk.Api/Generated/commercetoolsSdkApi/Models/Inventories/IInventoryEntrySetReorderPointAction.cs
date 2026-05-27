using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetReorderPointAction))]
    public partial interface IInventoryEntrySetReorderPointAction : IInventoryEntryUpdateAction
    {
        int? Quantity { get; set; }

    }
}
