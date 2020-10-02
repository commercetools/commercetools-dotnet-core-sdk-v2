using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    public partial class InventoryEntryUpdate 
    {
        public long Version { get; set;}
        
        public List<InventoryEntryUpdateAction> Actions { get; set;}
    }
}
