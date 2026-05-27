namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionDependencyExistsError : IExtensionDependencyExistsError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExtensionDependencyExistsError()
        {
            this.Code = "ExtensionDependencyExists";
        }
    }
}
