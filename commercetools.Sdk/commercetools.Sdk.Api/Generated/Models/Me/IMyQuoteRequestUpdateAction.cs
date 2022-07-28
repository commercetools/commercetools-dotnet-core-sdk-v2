using System;
using commercetools.Base.CustomAttributes;


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
