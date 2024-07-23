using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLLockedFieldError))]
    public partial interface IGraphQLLockedFieldError : IGraphQLErrorObject
    {
        string Field { get; set; }

        new string Code { get; set; }

    }
}
