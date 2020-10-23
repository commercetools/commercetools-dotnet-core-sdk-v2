using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Reviews
{
    public interface IReviewRatingStatistics 
    {
        double AverageRating { get; set;}
        
        double HighestRating { get; set;}
        
        double LowestRating { get; set;}
        
        int Count { get; set;}
        
        Object RatingsDistribution { get; set;}
    }
}
