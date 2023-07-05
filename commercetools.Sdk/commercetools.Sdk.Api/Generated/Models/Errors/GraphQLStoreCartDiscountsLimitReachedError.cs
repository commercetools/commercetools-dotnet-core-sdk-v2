using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class GraphQLStoreCartDiscountsLimitReachedError : IGraphQLStoreCartDiscountsLimitReachedError
    {
        public string Code { get; set; }

        public IList<IStoreKeyReference> Stores { get; set; }
        public IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

        public GraphQLStoreCartDiscountsLimitReachedError()
        {
            this.Code = "StoreCartDiscountsLimitReached";
        }
    }
}
