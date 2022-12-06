using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Carts
{

    public partial class CartPagedQueryResponse : ICartPagedQueryResponse
    {
        public long Limit { get; set; }

        public long Count { get; set; }

        public long? Total { get; set; }

        public long Offset { get; set; }

        public IList<ICart> Results { get; set; }
        public IEnumerable<ICart> ResultsEnumerable { set => Results = value.ToList(); }

    }
}
