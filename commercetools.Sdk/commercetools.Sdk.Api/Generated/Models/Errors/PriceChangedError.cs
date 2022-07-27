using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class PriceChangedError : IPriceChangedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public List<string> LineItems { get; set; }

        public bool Shipping { get; set; }
        public PriceChangedError()
        {
            this.Code = "PriceChanged";
        }
    }
}
