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
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewUpdate))]
    public partial interface IReviewUpdate
    {
        long Version { get; set; }

        IList<IReviewUpdateAction> Actions { get; set; }
        IEnumerable<IReviewUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
