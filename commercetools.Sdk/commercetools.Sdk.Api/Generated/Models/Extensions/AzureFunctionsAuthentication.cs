namespace commercetools.Api.Models.Extensions
{
    public partial class AzureFunctionsAuthentication : IAzureFunctionsAuthentication
    {
        public string Type { get; set; }

        public string Key { get; set; }
        public AzureFunctionsAuthentication()
        {
            this.Type = "AzureFunctions";
        }
    }
}
