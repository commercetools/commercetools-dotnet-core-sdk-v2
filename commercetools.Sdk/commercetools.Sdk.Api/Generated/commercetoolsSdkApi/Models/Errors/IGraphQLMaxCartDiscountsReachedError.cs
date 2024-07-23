using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMaxCartDiscountsReachedError))]
    public partial interface IGraphQLMaxCartDiscountsReachedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
