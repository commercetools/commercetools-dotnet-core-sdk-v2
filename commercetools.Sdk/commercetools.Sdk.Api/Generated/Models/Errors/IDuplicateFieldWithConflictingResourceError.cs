using commercetools.Api.Models.Common;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.DuplicateFieldWithConflictingResourceError))]
    public partial interface IDuplicateFieldWithConflictingResourceError : IErrorObject
    {
        string Field { get; set; }

        Object DuplicateValue { get; set; }

        IReference ConflictingResource { get; set; }
    }
}
