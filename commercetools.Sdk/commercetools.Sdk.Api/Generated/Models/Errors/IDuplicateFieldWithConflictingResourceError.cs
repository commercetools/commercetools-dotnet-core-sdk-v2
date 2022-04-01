using commercetools.Sdk.Api.Models.Common;
using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    public partial interface IDuplicateFieldWithConflictingResourceError : IErrorObject
    {
        string Field { get; set; }

        Object DuplicateValue { get; set; }

        IReference ConflictingResource { get; set; }
    }
}
