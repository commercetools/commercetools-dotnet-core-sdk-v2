using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateResponse))]
    public partial interface IVariantBulkUpdateResponse
    {
        int SuccessCount { get; set; }

        int FailureCount { get; set; }

        IList<IVariantBulkUpdateResult> Results { get; set; }

        IEnumerable<IVariantBulkUpdateResult> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
