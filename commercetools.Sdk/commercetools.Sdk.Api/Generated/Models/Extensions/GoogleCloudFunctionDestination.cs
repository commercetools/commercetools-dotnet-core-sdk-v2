namespace commercetools.Sdk.Api.Models.Extensions
{

    public partial class GoogleCloudFunctionDestination : IGoogleCloudFunctionDestination
    {
        public string Type { get; set; }

        public string Url { get; set; }
        public GoogleCloudFunctionDestination()
        {
            this.Type = "GoogleCloudFunction";
        }
    }
}
