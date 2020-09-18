using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public class ReviewUpdate 
    {
        public long Version { get; set;}
        
        public List<ReviewUpdateAction> Actions { get; set;}
    }
}
