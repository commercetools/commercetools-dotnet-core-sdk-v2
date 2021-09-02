using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentInteractionAddedMessagePayload))]
    public partial interface IPaymentInteractionAddedMessagePayload : IMessagePayload
    {
        ICustomFields Interaction { get; set; }
    }
}
