using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    public class InventoryEntryUpdate 
    {
        public long Version { get; set;}
        
        public List<InventoryEntryUpdateAction> Actions { get; set;}
    }
}
