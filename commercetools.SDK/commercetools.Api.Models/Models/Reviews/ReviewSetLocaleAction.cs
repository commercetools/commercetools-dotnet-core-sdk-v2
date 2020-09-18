using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setLocale")]
    public class ReviewSetLocaleAction : ReviewUpdateAction
    {
        public string Locale { get; set;}
    }
}
