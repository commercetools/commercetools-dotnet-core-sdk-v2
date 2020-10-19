using commercetools.Api.Models.Common;
using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEdit : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public string Key { get; set;}
        
        public OrderReference Resource { get; set;}
        
        public List<StagedOrderUpdateAction> StagedActions { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public OrderEditResult Result { get; set;}
        
        public string Comment { get; set;}
    }
}
