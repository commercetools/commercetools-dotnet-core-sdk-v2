using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError))]
    public partial interface IDuplicateEnumValuesError : IErrorObject
    {
        List<string> Duplicates { get; set; }

    }
}
