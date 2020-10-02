using commercetools.Api.Models.Orders;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setLineItemCustomType")]
    public partial class StagedOrderSetLineItemCustomTypeAction : StagedOrderUpdateAction
    {
        public string LineItemId { get; set;}
        
        public TypeResourceIdentifier Type { get; set;}
        
        public FieldContainer Fields { get; set;}
        public StagedOrderSetLineItemCustomTypeAction()
        { 
           this.Action = "setLineItemCustomType";
        }
    }
}
