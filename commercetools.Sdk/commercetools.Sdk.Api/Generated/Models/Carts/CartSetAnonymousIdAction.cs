using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartSetAnonymousIdAction : ICartSetAnonymousIdAction
    {
        public string Action { get; set;}
        
        public string AnonymousId { get; set;}
        public CartSetAnonymousIdAction()
        { 
           this.Action = "setAnonymousId";
        }
    }
}
