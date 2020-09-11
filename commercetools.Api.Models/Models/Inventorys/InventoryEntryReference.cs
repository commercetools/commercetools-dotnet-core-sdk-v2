using commercetools.Api.Models.Common;
using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Inventorys
{
    public class InventoryEntryReference : Reference
    {
        public InventoryEntry Obj { get; set;}
    }
}
