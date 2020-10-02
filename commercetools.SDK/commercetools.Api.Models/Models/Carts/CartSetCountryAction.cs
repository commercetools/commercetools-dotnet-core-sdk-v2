using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setCountry")]
    public partial class CartSetCountryAction : CartUpdateAction
    {
        public string Country { get; set;}
        public CartSetCountryAction()
        { 
           this.Action = "setCountry";
        }
    }
}
