using commercetools.Api.Models.OrderEdits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    [DiscriminatorValue("setKey")]
    public partial class OrderEditSetKeyAction : OrderEditUpdateAction
    {
        public string Key { get; set;}
        public OrderEditSetKeyAction()
        { 
           this.Action = "setKey";
        }
    }
}
