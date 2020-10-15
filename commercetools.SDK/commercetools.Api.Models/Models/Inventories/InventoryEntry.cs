using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Inventories
{
    public partial class InventoryEntry : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public string Sku { get; set;}
        
        public ChannelResourceIdentifier SupplyChannel { get; set;}
        
        public long QuantityOnStock { get; set;}
        
        public long AvailableQuantity { get; set;}
        
        public long RestockableInDays { get; set;}
        
        public DateTime ExpectedDelivery { get; set;}
        
        public CustomFields Custom { get; set;}
    }
}
