using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLDuplicatePriceScopeError))]
    public partial interface IGraphQLDuplicatePriceScopeError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IPrice ConflictingPrice { get; set; }

    }
}
