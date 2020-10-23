using commercetools.Api.Models.Common;
using commercetools.Api.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryReference))]
    public interface IInventoryEntryReference : IReference
    {
        IInventoryEntry Obj { get; set;}
    }
}
