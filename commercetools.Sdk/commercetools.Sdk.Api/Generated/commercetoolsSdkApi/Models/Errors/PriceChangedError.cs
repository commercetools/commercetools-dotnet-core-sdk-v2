using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class PriceChangedError : IPriceChangedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> LineItems { get; set; }

        public IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }

        public bool Shipping { get; set; }
        public PriceChangedError()
        {
            this.Code = "PriceChanged";
        }
    }
}
