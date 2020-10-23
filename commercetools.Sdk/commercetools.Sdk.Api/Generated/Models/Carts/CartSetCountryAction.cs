using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    public  partial class CartSetCountryAction : ICartSetCountryAction
    {
        public string Action { get; set;}
        
        public string Country { get; set;}
        public CartSetCountryAction()
        { 
           this.Action = "setCountry";
        }
    }
}
