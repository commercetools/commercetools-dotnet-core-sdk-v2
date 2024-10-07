using commercetools.Sdk.Api.Models.States;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentStatus))]
    public partial interface IPaymentStatus
    {
        string InterfaceCode { get; set; }

        string InterfaceText { get; set; }

        IStateReference State { get; set; }

    }
}
