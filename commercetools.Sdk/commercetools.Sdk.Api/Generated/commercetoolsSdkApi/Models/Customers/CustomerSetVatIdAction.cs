

namespace commercetools.Sdk.Api.Models.Customers
{

    public partial class CustomerSetVatIdAction : ICustomerSetVatIdAction
    {
        public string Action { get; set; }

        public string VatId { get; set; }
        public CustomerSetVatIdAction()
        {
            this.Action = "setVatId";
        }
    }
}
