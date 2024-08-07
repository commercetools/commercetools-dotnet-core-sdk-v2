using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
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
