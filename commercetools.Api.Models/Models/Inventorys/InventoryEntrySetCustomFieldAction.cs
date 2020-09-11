using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Inventorys
{
    public class InventoryEntrySetCustomFieldAction : InventoryEntryUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
