using commercetools.Sdk.Api.Models.Customers;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentSetCustomerAction))]
    public partial interface IPaymentSetCustomerAction : IPaymentUpdateAction
    {
        ICustomerResourceIdentifier Customer { get; set; }

    }
}
