using commercetools.Sdk.Api.Models.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentStatusDraft))]
    public partial interface IPaymentStatusDraft
    {
        string InterfaceCode { get; set; }

        string InterfaceText { get; set; }

        IStateResourceIdentifier State { get; set; }

    }
}
