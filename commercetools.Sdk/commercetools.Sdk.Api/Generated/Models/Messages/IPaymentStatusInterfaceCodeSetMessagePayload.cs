using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentStatusInterfaceCodeSetMessagePayload))]
    public interface IPaymentStatusInterfaceCodeSetMessagePayload : IMessagePayload
    {
        string PaymentId { get; set;}
        
        string InterfaceCode { get; set;}
    }
}
