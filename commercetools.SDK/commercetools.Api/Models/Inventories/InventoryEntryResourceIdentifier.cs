using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DiscriminatorValue("inventory-entry")]
    public partial class InventoryEntryResourceIdentifier : ResourceIdentifier
    {
        public InventoryEntryResourceIdentifier()
        { 
           this.TypeId = "inventory-entry";
        }
    }
}
