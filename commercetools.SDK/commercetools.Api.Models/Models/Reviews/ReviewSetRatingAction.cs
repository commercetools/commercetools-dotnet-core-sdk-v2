using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DiscriminatorValue("setRating")]
    public partial class ReviewSetRatingAction : ReviewUpdateAction
    {
        public int Rating { get; set;}
        public ReviewSetRatingAction()
        { 
           this.Action = "setRating";
        }
    }
}
