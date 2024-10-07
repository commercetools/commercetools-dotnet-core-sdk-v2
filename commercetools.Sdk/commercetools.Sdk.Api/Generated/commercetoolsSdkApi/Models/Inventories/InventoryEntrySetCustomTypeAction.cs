using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Inventories
{

    public partial class InventoryEntrySetCustomTypeAction : IInventoryEntrySetCustomTypeAction
    {
        public string Action { get; set; }

        public ITypeResourceIdentifier Type { get; set; }

        public IFieldContainer Fields { get; set; }
        public InventoryEntrySetCustomTypeAction()
        {
            this.Action = "setCustomType";
        }
    }
}
