

namespace commercetools.Sdk.CheckoutApi.Models.Responses
{

    public partial class MultipleVendorButtonContainers : IMultipleVendorButtonContainers
    {
        public string Code { get; set; }

        public string Severity { get; set; }

        public string Message { get; set; }

        public string CorrelationId { get; set; }
        public MultipleVendorButtonContainers()
        {
            this.Code = "multiple_vendor_button_containers";
        }
    }
}
