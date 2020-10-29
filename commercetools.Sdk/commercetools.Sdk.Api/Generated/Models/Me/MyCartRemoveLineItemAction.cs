using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    public partial class MyCartRemoveLineItemAction : IMyCartRemoveLineItemAction
    {
        public string Action { get; set;}
        
        public string LineItemId { get; set;}
        
        public double? Quantity { get; set;}
        
        public IMoney ExternalPrice { get; set;}
        
        public IExternalLineItemTotalPrice ExternalTotalPrice { get; set;}
        
        public IItemShippingDetailsDraft ShippingDetailsToRemove { get; set;}
        public MyCartRemoveLineItemAction()
        { 
           this.Action = "removeLineItem";
        }
    }
}
