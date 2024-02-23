using commercetools.Sdk.Api.Models.Common;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntryReference : IInventoryEntryReference
    {
        public IReferenceTypeId TypeId { get; set; }

        public string Id { get; set; }

        public IInventoryEntry Obj { get; set; }
        public InventoryEntryReference()
        {
            this.TypeId = IReferenceTypeId.FindEnum("inventory-entry");
        }
    }
}
