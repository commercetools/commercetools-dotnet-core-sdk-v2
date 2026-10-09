using commercetools.Sdk.CheckoutApi.Models.Common;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.CheckoutApi.Models.RecurringPayments
{
    [DeserializeAs(typeof(commercetools.Sdk.CheckoutApi.Models.RecurringPayments.RecurringOrderReference))]
    public partial interface IRecurringOrderReference : IReference
    {
        new IReferenceTypeId TypeId { get; set; }

        new string Id { get; set; }

    }
}
