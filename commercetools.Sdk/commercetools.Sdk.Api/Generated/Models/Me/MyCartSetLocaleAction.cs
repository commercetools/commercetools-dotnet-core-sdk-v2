using commercetools.Api.Models.Me;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DiscriminatorValue("setLocale")]
    public partial class MyCartSetLocaleAction : MyCartUpdateAction
    {
        public string Locale { get; set;}
        public MyCartSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
