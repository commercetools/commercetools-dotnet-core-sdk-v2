using commercetools.Api.Models.Carts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Carts
{
    [DiscriminatorValue("setLocale")]
    public partial class CartSetLocaleAction : CartUpdateAction
    {
        public string Locale { get; set;}
        public CartSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
