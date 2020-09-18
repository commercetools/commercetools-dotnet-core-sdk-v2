using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLocale")]
    public class MyCartSetLocaleAction : MyCartUpdateAction
    {
        public string Locale { get; set;}
    }
}
