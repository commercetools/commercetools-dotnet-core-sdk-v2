using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditUpdate 
    {
        public long Version { get; set;}
        
        public List<OrderEditUpdateAction> Actions { get; set;}
        
        public bool DryRun { get; set;}
    }
}
