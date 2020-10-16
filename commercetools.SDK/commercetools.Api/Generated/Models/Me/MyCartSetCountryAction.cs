using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCountry")]
    public partial class MyCartSetCountryAction : MyCartUpdateAction
    {
        public string Country { get; set;}
        public MyCartSetCountryAction()
        { 
           this.Action = "setCountry";
        }
    }
}
