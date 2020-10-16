using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditDraft 
    {
        public string Key { get; set;}
        
        public OrderReference Resource { get; set;}
        
        public List<StagedOrderUpdateAction> StagedActions { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Comment { get; set;}
        
        public bool DryRun { get; set;}
    }
}
