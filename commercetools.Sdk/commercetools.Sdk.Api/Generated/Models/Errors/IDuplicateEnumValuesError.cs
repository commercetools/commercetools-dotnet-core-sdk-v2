using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicateEnumValuesError))]
    public partial interface IDuplicateEnumValuesError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        List<string> Duplicates { get; set; }

    }
}
