using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerCustomTypeSetMessagePayload : ICustomerCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string PreviousTypeId { get; set; }
        public CustomerCustomTypeSetMessagePayload()
        {
            this.Type = "CustomerCustomTypeSet";
        }
    }
}
