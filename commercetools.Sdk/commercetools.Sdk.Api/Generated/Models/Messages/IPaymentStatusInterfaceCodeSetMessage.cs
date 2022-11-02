using System;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessage))]
    public partial interface IPaymentStatusInterfaceCodeSetMessage : IMessage
    {
        [ObsoleteAttribute("This property is obsolete", false)]
        string PaymentId { get; set; }

        string InterfaceCode { get; set; }

    }
}
