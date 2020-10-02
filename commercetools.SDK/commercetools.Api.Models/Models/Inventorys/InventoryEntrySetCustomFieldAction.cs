using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("setCustomField")]
    public partial class InventoryEntrySetCustomFieldAction : InventoryEntryUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
        public InventoryEntrySetCustomFieldAction()
        { 
           this.Action = "setCustomField";
        }
    }
}
