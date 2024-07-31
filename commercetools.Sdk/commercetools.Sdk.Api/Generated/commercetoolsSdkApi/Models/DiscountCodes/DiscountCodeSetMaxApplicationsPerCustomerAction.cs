

namespace commercetools.Sdk.Api.Models.DiscountCodes
{

    public partial class DiscountCodeSetMaxApplicationsPerCustomerAction : IDiscountCodeSetMaxApplicationsPerCustomerAction
    {
        public string Action { get; set; }

        public long? MaxApplicationsPerCustomer { get; set; }
        public DiscountCodeSetMaxApplicationsPerCustomerAction()
        {
            this.Action = "setMaxApplicationsPerCustomer";
        }
    }
}
