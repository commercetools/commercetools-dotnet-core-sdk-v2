using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartAddItemShippingAddressAction : ICartAddItemShippingAddressAction
    {
        public string Action { get; set;}
        
        public IAddress Address { get; set;}
        public CartAddItemShippingAddressAction()
        { 
           this.Action = "addItemShippingAddress";
        }
    }
}
