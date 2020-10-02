using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCustomerEmail")]
    public partial class CartSetCustomerEmailAction : CartUpdateAction
    {
        public string Email { get; set;}
        public CartSetCustomerEmailAction()
        { 
           this.Action = "setCustomerEmail";
        }
    }
}
