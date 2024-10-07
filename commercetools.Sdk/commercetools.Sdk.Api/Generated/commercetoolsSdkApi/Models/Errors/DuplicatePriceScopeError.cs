using commercetools.Sdk.Api.Models.Common;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class DuplicatePriceScopeError : IDuplicatePriceScopeError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IPrice ConflictingPrice { get; set; }
        public DuplicatePriceScopeError()
        {
            this.Code = "DuplicatePriceScope";
        }
    }
}
