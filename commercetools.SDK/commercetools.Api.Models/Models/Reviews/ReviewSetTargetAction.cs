using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setTarget")]
    public class ReviewSetTargetAction : ReviewUpdateAction
    {
        public Object Target { get; set;}
    }
}
