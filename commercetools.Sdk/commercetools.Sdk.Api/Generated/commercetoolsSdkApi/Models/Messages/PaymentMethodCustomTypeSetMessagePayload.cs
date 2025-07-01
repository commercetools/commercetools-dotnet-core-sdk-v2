using commercetools.Sdk.Api.Models.Types;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentMethodCustomTypeSetMessagePayload : IPaymentMethodCustomTypeSetMessagePayload
    {
        public string Type { get; set; }

        public ICustomFields CustomFields { get; set; }

        public string OldTypeId { get; set; }
        public PaymentMethodCustomTypeSetMessagePayload()
        {
            this.Type = "PaymentMethodCustomTypeSet";
        }
    }
}
