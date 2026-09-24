namespace commercetools.Sdk.Api.Models.Errors
{

    public partial class ExtensionCircularDependencyError : IExtensionCircularDependencyError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ExtensionCircularDependencyError()
        {
            this.Code = "ExtensionCircularDependency";
        }
    }
}
