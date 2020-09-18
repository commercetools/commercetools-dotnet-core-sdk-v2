using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [Discriminator(nameof(Action))]
    public abstract class ReviewUpdateAction 
    {
        public string Action { get; set;}
    }
}
