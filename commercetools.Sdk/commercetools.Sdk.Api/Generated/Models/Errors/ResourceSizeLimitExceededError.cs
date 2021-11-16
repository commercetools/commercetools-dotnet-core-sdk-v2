namespace commercetools.Api.Models.Errors
{
    public partial class ResourceSizeLimitExceededError : IResourceSizeLimitExceededError
    {
        public string Code { get; set; }

        public string Message { get; set; }
        public ResourceSizeLimitExceededError()
        {
            this.Code = "ResourceSizeLimitExceeded";
        }
    }
}
