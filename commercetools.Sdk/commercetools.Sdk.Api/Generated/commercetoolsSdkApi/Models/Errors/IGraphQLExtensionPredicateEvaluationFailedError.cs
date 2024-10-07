using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.GraphQLExtensionPredicateEvaluationFailedError))]
    public partial interface IGraphQLExtensionPredicateEvaluationFailedError : IGraphQLErrorObject
    {
        new string Code { get; set; }

        IErrorByExtension ErrorByExtension { get; set; }

    }
}
