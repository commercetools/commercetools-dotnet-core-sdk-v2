using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntryDraft))]
    public interface IInventoryEntryDraft 
    {
        string Sku { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        long QuantityOnStock { get; set;}
        
        long? RestockableInDays { get; set;}
        
        DateTime ExpectedDelivery { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
    }
}
