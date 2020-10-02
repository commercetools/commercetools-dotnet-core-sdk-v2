using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("setExpectedDelivery")]
    public partial class InventoryEntrySetExpectedDeliveryAction : InventoryEntryUpdateAction
    {
        public DateTime ExpectedDelivery { get; set;}
        public InventoryEntrySetExpectedDeliveryAction()
        { 
           this.Action = "setExpectedDelivery";
        }
    }
}
