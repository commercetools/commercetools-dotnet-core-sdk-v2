using commercetools.Sdk.Api.Models.Common;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class DuplicatePriceScopeError : IDuplicatePriceScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<IPrice> ConflictingPrices { get; set; }
        public IEnumerable<IPrice> ConflictingPricesEnumerable { set => ConflictingPrices = value.ToList(); }

        public DuplicatePriceScopeError()
        {
            this.Code = "DuplicatePriceScope";
        }
    }
}
