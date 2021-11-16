using System;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntrySetCustomFieldAction : IInventoryEntrySetCustomFieldAction
    {
        public string Action { get; set;}
        
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public InventoryEntrySetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
