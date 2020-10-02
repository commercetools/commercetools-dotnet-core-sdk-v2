using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewUpdate 
    {
        public long Version { get; set;}
        
        public List<ReviewUpdateAction> Actions { get; set;}
    }
}
