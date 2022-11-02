using System;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class PaymentStatusInterfaceCodeSetMessagePayload : IPaymentStatusInterfaceCodeSetMessagePayload
    {
        public string Type { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public string PaymentId { get; set; }

        public string InterfaceCode { get; set; }
        public PaymentStatusInterfaceCodeSetMessagePayload()
        {
            this.Type = "PaymentStatusInterfaceCodeSet";
        }
    }
}
