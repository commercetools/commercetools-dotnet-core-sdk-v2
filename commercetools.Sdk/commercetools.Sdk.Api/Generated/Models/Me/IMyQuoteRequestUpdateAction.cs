using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestUpdateAction))]
    [SubTypeDiscriminator("cancelQuoteRequest", typeof(commercetools.Sdk.Api.Models.Me.MyQuoteRequestCancelAction))]
    public partial interface IMyQuoteRequestUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyQuoteRequestCancelAction CancelQuoteRequest(Action<commercetools.Sdk.Api.Models.Me.MyQuoteRequestCancelAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyQuoteRequestCancelAction();
            init?.Invoke(t);
            return t;
        }
    }
}
