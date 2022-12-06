using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.PriceChangedError))]
    public partial interface IPriceChangedError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        List<string> LineItems { get; set; }

        bool Shipping { get; set; }

    }
}
