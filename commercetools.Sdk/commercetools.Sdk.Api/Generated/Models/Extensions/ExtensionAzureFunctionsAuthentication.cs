namespace commercetools.Api.Models.Extensions
{
    public partial class ExtensionAzureFunctionsAuthentication : IExtensionAzureFunctionsAuthentication
    {
        public string Type { get; set; }

        public string Key { get; set; }
        public ExtensionAzureFunctionsAuthentication()
        {
            this.Type = "AzureFunctions";
        }
    }
}
