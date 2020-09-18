using commercetools.Api.Models.Inventorys;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Inventorys
{
    [Discriminator(nameof(Action))]
    public abstract class InventoryEntryUpdateAction 
    {
        public string Action { get; set;}
    }
}
