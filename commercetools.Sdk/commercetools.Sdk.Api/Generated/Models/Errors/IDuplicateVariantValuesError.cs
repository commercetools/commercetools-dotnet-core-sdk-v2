using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Api.Models.Errors.DuplicateVariantValuesError))]
    public partial interface IDuplicateVariantValuesError : IErrorObject
    {
        IVariantValues VariantValues { get; set;}
    }
}
