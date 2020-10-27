using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public  partial class OrderEditUpdate : IOrderEditUpdate
    {
        public long Version { get; set;}
        
        public List<IOrderEditUpdateAction> Actions { get; set;}
        
        public bool? DryRun { get; set;}
    }
}
