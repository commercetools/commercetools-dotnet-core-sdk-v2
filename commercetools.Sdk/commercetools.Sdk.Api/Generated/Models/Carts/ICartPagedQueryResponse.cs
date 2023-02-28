using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Carts
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Carts.CartPagedQueryResponse))]
    public partial interface ICartPagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<ICart> Results { get; set; }
        IEnumerable<ICart> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
