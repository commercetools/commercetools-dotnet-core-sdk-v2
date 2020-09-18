using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setCustomField")]
    public class ReviewSetCustomFieldAction : ReviewUpdateAction
    {
        public string Name { get; set;}
        
        public Object Value { get; set;}
    }
}
