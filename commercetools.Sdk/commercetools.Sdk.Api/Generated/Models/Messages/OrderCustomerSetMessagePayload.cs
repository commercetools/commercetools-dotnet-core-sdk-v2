using commercetools.Sdk.Api.Models.CustomerGroups;
using commercetools.Sdk.Api.Models.Customers;


namespace commercetools.Sdk.Api.Models.Messages
{
    public partial class OrderCustomerSetMessagePayload : IOrderCustomerSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomerReference Customer { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public ICustomerReference OldCustomer { get; set; }

        public ICustomerGroupReference OldCustomerGroup { get; set; }
        public OrderCustomerSetMessagePayload()
        {
            this.Type = "OrderCustomerSet";
        }
    }
}
