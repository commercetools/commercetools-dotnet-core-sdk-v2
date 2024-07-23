using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class OrderCustomerGroupSetMessagePayload : IOrderCustomerGroupSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }

        public ICustomerGroupReference OldCustomerGroup { get; set; }
        public OrderCustomerGroupSetMessagePayload()
        {
            this.Type = "OrderCustomerGroupSet";
        }
    }
}
