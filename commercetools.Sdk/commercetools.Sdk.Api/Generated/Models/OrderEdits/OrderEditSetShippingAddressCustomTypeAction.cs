using commercetools.Api.Models.OrderEdits;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class OrderEditSetShippingAddressCustomTypeAction : IOrderEditSetShippingAddressCustomTypeAction
    {
        public string Action { get; set;}
        
        public ITypeResourceIdentifier Type { get; set;}
        
        public IFieldContainer Fields { get; set;}
        public OrderEditSetShippingAddressCustomTypeAction()
        { 
           this.Action = "setShippingAddressCustomType";
        }
    }
}
