using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setCustomType")]
    public partial class OrderEditSetCustomTypeAction : OrderEditUpdateAction
    {
        public TypeResourceIdentifier Type { get; set;}
        
        public Object Fields { get; set;}
        public OrderEditSetCustomTypeAction()
        { 
           this.Action = "setCustomType";
        }
    }
}
