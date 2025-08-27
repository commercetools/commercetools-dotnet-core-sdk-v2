using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLMaxDiscountGroupsReachedError))]
    public partial interface IGraphQLMaxDiscountGroupsReachedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
