using commercetools.Sdk.Api.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentReference))]
    public partial interface IPaymentReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        IPayment Obj { get; set; }

        new string Id { get; set; }

    }
}
