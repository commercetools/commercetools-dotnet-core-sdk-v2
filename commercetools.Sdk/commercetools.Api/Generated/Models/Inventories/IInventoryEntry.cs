using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Inventories
{
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
