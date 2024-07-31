using commercetools.Base.CustomAttributes;
using System;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [TypeDiscriminator(nameof(Action))]
    [DefaultTypeDiscriminator(typeof(commercetools.Sdk.Api.Models.Me.MyQuoteUpdateAction))]
    [SubTypeDiscriminator("changeMyQuoteState", typeof(commercetools.Sdk.Api.Models.Me.MyQuoteChangeMyQuoteStateAction))]
    public partial interface IMyQuoteUpdateAction
    {
        string Action { get; set; }

        static commercetools.Sdk.Api.Models.Me.MyQuoteChangeMyQuoteStateAction ChangeMyQuoteState(Action<commercetools.Sdk.Api.Models.Me.MyQuoteChangeMyQuoteStateAction> init = null)
        {
            var t = new commercetools.Sdk.Api.Models.Me.MyQuoteChangeMyQuoteStateAction();
            init?.Invoke(t);
            return t;
        }
    }
}
