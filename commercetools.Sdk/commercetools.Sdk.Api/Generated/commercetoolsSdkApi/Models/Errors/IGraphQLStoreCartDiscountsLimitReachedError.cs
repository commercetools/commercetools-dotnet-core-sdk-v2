using commercetools.Sdk.Api.Models.Stores;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLStoreCartDiscountsLimitReachedError))]
    public partial interface IGraphQLStoreCartDiscountsLimitReachedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IList<IStoreKeyReference> Stores { get; set; }

        IEnumerable<IStoreKeyReference> StoresEnumerable { set => Stores = value.ToList(); }

    }
}
