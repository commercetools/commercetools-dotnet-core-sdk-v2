namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionChainTooWideError : IExtensionChainTooWideError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExtensionChainTooWideError()
        {
            this.Code = "ExtensionChainTooWide";
        }
    }
}
