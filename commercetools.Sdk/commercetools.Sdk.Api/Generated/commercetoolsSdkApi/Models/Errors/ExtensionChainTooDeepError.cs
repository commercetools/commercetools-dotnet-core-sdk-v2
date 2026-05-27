namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionChainTooDeepError : IExtensionChainTooDeepError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExtensionChainTooDeepError()
        {
            this.Code = "ExtensionChainTooDeep";
        }
    }
}
