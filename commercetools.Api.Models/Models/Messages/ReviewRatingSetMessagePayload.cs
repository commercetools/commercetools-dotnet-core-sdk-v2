using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Messages
{
    public class ReviewRatingSetMessagePayload : MessagePayload
    {
        public double OldRating { get; set;}
        
        public double NewRating { get; set;}
        
        public bool IncludedInStatistics { get; set;}
        
        public Reference Target { get; set;}
    }
}
