using commercetools.Api.Models.Common;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryReference))]
    public partial interface IInventoryEntryReference : IReference
    {
        IInventoryEntry Obj { get; set; }
    }
}
