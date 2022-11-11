using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError))]
    public partial interface IDuplicatePriceScopeError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        List<IPrice> ConflictingPrices { get; set; }

    }
}
