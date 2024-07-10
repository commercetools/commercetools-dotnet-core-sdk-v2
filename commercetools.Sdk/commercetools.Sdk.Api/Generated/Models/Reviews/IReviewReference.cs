using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Reviews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewReference))]
    public partial interface IReviewReference : IReference
    {
        IReview Obj { get; set; }

        new string Id { get; set; }

    }
}
