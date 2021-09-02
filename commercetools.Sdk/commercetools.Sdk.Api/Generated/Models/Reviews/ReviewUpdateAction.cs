using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Reviews
{
    public partial class ReviewUpdateAction : IReviewUpdateAction
    {
        public string Action { get; set; }
    }
}
