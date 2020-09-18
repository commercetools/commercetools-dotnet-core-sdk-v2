using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("setCustomField")]
    public class InventoryEntrySetCustomFieldAction : InventoryEntryUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
