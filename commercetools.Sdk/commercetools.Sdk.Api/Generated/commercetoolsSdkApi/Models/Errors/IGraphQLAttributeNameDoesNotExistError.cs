using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLAttributeNameDoesNotExistError))]
    public partial interface IGraphQLAttributeNameDoesNotExistError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        string InvalidAttributeName { get; set; }

    }
}
