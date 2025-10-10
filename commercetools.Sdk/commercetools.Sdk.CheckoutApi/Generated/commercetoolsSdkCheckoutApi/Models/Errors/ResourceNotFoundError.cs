

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class ResourceNotFoundError : IResourceNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ResourceIdentifier { get; set; }

        public string ResourceId { get; set; }
        public ResourceNotFoundError()
        {
            this.Code = "ResourceNotFound";
        }
    }
}
