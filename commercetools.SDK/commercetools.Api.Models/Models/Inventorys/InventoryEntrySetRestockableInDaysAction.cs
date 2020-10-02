using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("setRestockableInDays")]
    public partial class InventoryEntrySetRestockableInDaysAction : InventoryEntryUpdateAction
    {
        public long RestockableInDays { get; set;}
        public InventoryEntrySetRestockableInDaysAction()
        { 
           this.Action = "setRestockableInDays";
        }
    }
}
