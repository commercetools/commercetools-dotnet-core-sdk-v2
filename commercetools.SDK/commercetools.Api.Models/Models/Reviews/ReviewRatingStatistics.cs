using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Api.Serialization.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public class ReviewRatingStatistics 
    {
        public double AverageRating { get; set;}
        
        public double HighestRating { get; set;}
        
        public double LowestRating { get; set;}
        
        public int Count { get; set;}
        
        public Object RatingsDistribution { get; set;}
    }
}
