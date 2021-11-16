namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntrySetRestockableInDaysAction : IInventoryEntrySetRestockableInDaysAction
    {
        public string Action { get; set;}
        
        public long? RestockableInDays { get; set;}
        public InventoryEntrySetRestockableInDaysAction()
        { 
           this.Action = "setRestockableInDays";
        }
    }
}
