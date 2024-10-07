

namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class CustomerCustomTypeRemovedMessagePayload : ICustomerCustomTypeRemovedMessagePayload
    {
        public string Type { get; set; }

        public string PreviousTypeId { get; set; }
        public CustomerCustomTypeRemovedMessagePayload()
        {
            this.Type = "CustomerCustomTypeRemoved";
        }
    }
}
