using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartRemoveDiscountCodeAction : ICartRemoveDiscountCodeAction
    {
        public string Action { get; set;}
        
        public IDiscountCodeReference DiscountCode { get; set;}
        public CartRemoveDiscountCodeAction()
        { 
           this.Action = "removeDiscountCode";
        }
    }
}
