using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class OutOfStockError : IOutOfStockError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IList<string> LineItems { get; set; }
        public IEnumerable<string> LineItemsEnumerable { set => LineItems = value.ToList(); }


        public IList<string> Skus { get; set; }
        public IEnumerable<string> SkusEnumerable { set => Skus = value.ToList(); }

        public OutOfStockError()
        {
            this.Code = "OutOfStock";
        }
    }
}
