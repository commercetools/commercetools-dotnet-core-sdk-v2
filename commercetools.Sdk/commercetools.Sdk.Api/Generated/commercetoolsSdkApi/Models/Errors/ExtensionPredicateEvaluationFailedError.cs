namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionPredicateEvaluationFailedError : IExtensionPredicateEvaluationFailedError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public IErrorByExtension ErrorByExtension { get; set; }
        public ExtensionPredicateEvaluationFailedError()
        {
            this.Code = "ExtensionPredicateEvaluationFailed";
        }
    }
}
