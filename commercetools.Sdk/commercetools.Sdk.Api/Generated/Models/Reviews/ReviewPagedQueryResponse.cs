using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewPagedQueryResponse : IReviewPagedQueryResponse
    {
        public long Limit { get; set;}
        
        public long Count { get; set;}
        
        public long? Total { get; set;}
        
        public long Offset { get; set;}
        
        public List<IReview> Results { get; set;}
    }
}
