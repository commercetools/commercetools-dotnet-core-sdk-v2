

namespace commercetools.Sdk.CheckoutApi.Models.Errors
{

    public partial class ConcurrentModificationError : IConcurrentModificationError
    {
        public string Code { get; set; }

        public string Message { get; set; }

        public string ResourceId { get; set; }

        public long ExpectedVersion { get; set; }

        public long CurrentVersion { get; set; }
        public ConcurrentModificationError()
        {
            this.Code = "ConcurrentModification";
        }
    }
}
