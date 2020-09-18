using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [DiscriminatorValue("setExpectedDelivery")]
    public class InventoryEntrySetExpectedDeliveryAction : InventoryEntryUpdateAction
    {
        public DateTime ExpectedDelivery { get; set;}
    }
}
