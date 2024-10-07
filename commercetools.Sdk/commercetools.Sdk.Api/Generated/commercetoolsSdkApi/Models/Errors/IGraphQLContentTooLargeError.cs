using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLContentTooLargeError))]
    public partial interface IGraphQLContentTooLargeError : IGraphQLErrorObject
    {
        new string Code { get; set; }

    }
}
