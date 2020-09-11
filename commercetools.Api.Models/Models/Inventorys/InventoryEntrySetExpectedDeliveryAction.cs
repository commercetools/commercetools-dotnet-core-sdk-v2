using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Inventorys
{
    public class InventoryEntrySetExpectedDeliveryAction : InventoryEntryUpdateAction
    {
        public DateTime ExpectedDelivery { get; set;}
    }
}
