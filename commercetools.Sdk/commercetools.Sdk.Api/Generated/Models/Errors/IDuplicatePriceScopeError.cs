using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.DuplicatePriceScopeError))]
    public partial interface IDuplicatePriceScopeError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IList<IPrice> ConflictingPrices { get; set; }
        IEnumerable<IPrice> ConflictingPricesEnumerable { set => ConflictingPrices = value.ToList(); }


    }
}
