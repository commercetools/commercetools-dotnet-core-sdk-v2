using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomerId")]
    public partial class CartSetCustomerIdAction : CartUpdateAction
    {
        public string CustomerId { get; set;}
        public CartSetCustomerIdAction()
        { 
           this.Action = "setCustomerId";
        }
    }
}
