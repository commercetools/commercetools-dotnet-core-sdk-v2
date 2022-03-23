using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntrySetKeyAction))]
    public partial interface IInventoryEntrySetKeyAction : IInventoryEntryUpdateAction
    {
        string Key { get; set; }
    }
}
