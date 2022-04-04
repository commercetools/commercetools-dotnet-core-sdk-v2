using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Inventories.InventoryEntrySetKeyAction))]
    public partial interface IInventoryEntrySetKeyAction : IInventoryEntryUpdateAction
    {
        string Key { get; set; }
    }
}
