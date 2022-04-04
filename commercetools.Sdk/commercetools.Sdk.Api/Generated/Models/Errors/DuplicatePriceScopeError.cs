using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class DuplicatePriceScopeError : IDuplicatePriceScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<IPrice> ConflictingPrices { get; set; }
        public DuplicatePriceScopeError()
        {
            this.Code = "DuplicatePriceScope";
        }
    }
}
