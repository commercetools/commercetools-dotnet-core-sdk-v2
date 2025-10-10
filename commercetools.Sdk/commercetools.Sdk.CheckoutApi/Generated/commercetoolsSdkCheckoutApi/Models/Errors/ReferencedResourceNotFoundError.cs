

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class ReferencedResourceNotFoundError : IReferencedResourceNotFoundError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string TypeId { get; set; }

        public string Id { get; set; }

        public string Key { get; set; }
        public ReferencedResourceNotFoundError()
        {
            this.Code = "ReferencedResourceNotFound";
        }
    }
}
