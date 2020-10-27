using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public  partial class ReviewSetRatingAction : IReviewSetRatingAction
    {
        public string Action { get; set;}
        
        public int? Rating { get; set;}
        public ReviewSetRatingAction()
        { 
           this.Action = "setRating";
        }
    }
}
