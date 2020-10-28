using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewUpdate : IReviewUpdate
    {
        public long Version { get; set;}
        
        public List<IReviewUpdateAction> Actions { get; set;}
    }
}
