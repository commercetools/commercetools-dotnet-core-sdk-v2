using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLConcurrentModificationError))]
    public partial interface IGraphQLConcurrentModificationError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        long? CurrentVersion { get; set; }

    }
}
