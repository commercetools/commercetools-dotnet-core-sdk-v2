namespace commercetools.Sdk.Api.Models.Errors
{
    public partial class FeatureRemovedError : IFeatureRemovedError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public FeatureRemovedError()
        {
            this.Code = "FeatureRemoved";
        }
    }
}
