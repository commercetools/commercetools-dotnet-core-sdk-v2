using commercetools.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Api.Models.Reviews.ReviewSetAuthorNameAction))]
    public partial interface IReviewSetAuthorNameAction : IReviewUpdateAction
    {
        string AuthorName { get; set;}
    }
}
