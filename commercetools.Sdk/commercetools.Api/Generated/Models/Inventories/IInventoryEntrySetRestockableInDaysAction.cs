using commercetools.Api.Generated.Models.Inventories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Inventories
{
    public interface IInventoryEntrySetRestockableInDaysAction : IInventoryEntryUpdateAction
    {
        long RestockableInDays { get; set;}
    }
}
