using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setKey")]
    public class ReviewSetKeyAction : ReviewUpdateAction
    {
        public string Key { get; set;}
    }
}
