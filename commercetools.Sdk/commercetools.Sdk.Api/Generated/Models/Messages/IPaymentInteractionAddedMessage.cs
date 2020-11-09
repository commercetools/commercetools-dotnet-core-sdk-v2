using commercetools.Api.Models.Common;
using commercetools.Api.Models.Messages;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Api.Models.Messages.PaymentInteractionAddedMessage))]
    public partial interface IPaymentInteractionAddedMessage : IMessage
    {
        ICustomFields Interaction { get; set;}
    }
}
