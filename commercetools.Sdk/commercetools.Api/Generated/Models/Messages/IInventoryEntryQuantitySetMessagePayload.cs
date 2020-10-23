using commercetools.Api.Generated.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Messages
{
    public interface IInventoryEntryQuantitySetMessagePayload : IMessagePayload
    {
        long OldQuantityOnStock { get; set;}
        
        long NewQuantityOnStock { get; set;}
        
        long OldAvailableQuantity { get; set;}
        
        long NewAvailableQuantity { get; set;}
    }
}
