using commercetools.Sdk.Api.Models.Errors;
using commercetools.Sdk.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
