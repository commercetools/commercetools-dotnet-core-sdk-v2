using commercetools.Api.Generated.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Reviews
{
    public interface IReviewSetRatingAction : IReviewUpdateAction
    {
        int Rating { get; set;}
    }
}
