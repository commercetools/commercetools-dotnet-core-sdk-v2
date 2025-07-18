using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Messages
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Messages.PaymentMethodInfoNameSetMessagePayload))]
    public partial interface IPaymentMethodInfoNameSetMessagePayload : IMessagePayload
    {
        ILocalizedString Name { get; set; }

        ILocalizedString OldName { get; set; }

    }
}
