using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.OutOfStockError))]
    public partial interface IOutOfStockError : IErrorObject
    {
        List<string> LineItems { get; set; }

        List<string> Skus { get; set; }

    }
}
