using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Stores
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Stores.StorePagedQueryResponse))]
    public partial interface IStorePagedQueryResponse
    {
        long Limit { get; set; }

        long Offset { get; set; }

        long Count { get; set; }

        long? Total { get; set; }

        IList<IStore> Results { get; set; }
        IEnumerable<IStore> ResultsEnumerable { set => Results = value.ToList(); }


    }
}
