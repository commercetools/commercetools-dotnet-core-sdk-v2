using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerAddressCustomTypeSetMessagePayload : ICustomerAddressCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string PreviousTypeId { get; set; }
        public CustomerAddressCustomTypeSetMessagePayload()
        {
            this.Type = "CustomerAddressCustomTypeSet";
        }
    }
}
