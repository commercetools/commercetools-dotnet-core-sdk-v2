using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setCountry")]
    public class MyCartSetCountryAction : MyCartUpdateAction
    {
        public string Country { get; set;}
    }
}
