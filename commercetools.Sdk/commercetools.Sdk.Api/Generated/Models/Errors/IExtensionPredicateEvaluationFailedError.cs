using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Errors
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Errors.ExtensionPredicateEvaluationFailedError))]
    public partial interface IExtensionPredicateEvaluationFailedError : IErrorObject
    {
        new string Code { get; set; }

        new string Message { get; set; }

        IErrorByExtension ErrorByExtension { get; set; }

    }
}
