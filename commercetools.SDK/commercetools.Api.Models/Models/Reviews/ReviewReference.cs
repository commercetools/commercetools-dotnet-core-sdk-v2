using commercetools.Api.Models.Common;
using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("review")]
    public class ReviewReference : Reference
    {
        public Review Obj { get; set;}
    }
}
