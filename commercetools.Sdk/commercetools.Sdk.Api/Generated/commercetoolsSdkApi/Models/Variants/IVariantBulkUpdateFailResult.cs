using commercetools.Sdk.Api.Models.Errors;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Variants
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Variants.VariantBulkUpdateFailResult))]
    public partial interface IVariantBulkUpdateFailResult : IVariantBulkUpdateResult
    {
        IList<IErrorObject> Errors { get; set; }

        IEnumerable<IErrorObject> ErrorsEnumerable { set => Errors = value.ToList(); }

    }
}
