using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Reviews
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Reviews.ReviewUpdate))]
    public partial interface IReviewUpdate : commercetools.Sdk.Api.Models.IResourceUpdate<IReviewUpdate, IReviewUpdateAction>
    {
        new long Version { get; set; }
        new IList<IReviewUpdateAction> Actions { get; set; }
        IEnumerable<IReviewUpdateAction> ActionsEnumerable { set => Actions = value.ToList(); }


    }
}
