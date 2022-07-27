using commercetools.Sdk.Api.Models.CustomerGroups;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerGroupSetMessagePayload : ICustomerGroupSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomerGroupReference CustomerGroup { get; set; }
        public CustomerGroupSetMessagePayload()
        {
            this.Type = "CustomerGroupSet";
        }
    }
}
