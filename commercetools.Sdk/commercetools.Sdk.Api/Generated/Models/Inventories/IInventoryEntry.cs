using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    [DeserializeAs(typeof(commercetools.Api.Models.Inventories.InventoryEntry))]
    public interface IInventoryEntry : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Sku { get; set;}
        
        IChannelResourceIdentifier SupplyChannel { get; set;}
        
        long QuantityOnStock { get; set;}
        
        long AvailableQuantity { get; set;}
        
        long RestockableInDays { get; set;}
        
        DateTime ExpectedDelivery { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
