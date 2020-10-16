using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setLocale")]
    public partial class ReviewSetLocaleAction : ReviewUpdateAction
    {
        public string Locale { get; set;}
        public ReviewSetLocaleAction()
        { 
           this.Action = "setLocale";
        }
    }
}
