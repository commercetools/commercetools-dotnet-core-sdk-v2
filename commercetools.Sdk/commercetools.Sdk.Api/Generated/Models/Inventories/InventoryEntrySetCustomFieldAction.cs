using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public  partial class InventoryEntrySetCustomFieldAction : IInventoryEntrySetCustomFieldAction
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
