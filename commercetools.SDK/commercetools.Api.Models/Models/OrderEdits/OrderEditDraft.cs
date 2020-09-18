using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public class OrderEditDraft 
    {
        public string Key { get; set;}
        
        public OrderReference Resource { get; set;}
        
        public List<StagedOrderUpdateAction> StagedActions { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Comment { get; set;}
        
        public bool DryRun { get; set;}
    }
}
