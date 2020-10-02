using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setAnonymousId")]
    public partial class CartSetAnonymousIdAction : CartUpdateAction
    {
        public string AnonymousId { get; set;}
        public CartSetAnonymousIdAction()
        { 
           this.Action = "setAnonymousId";
        }
    }
}
