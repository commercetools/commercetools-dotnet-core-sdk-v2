namespace commercetools.Sdk.Api.Models.Payments;

public partial interface IPaymentMethodInfo
{
    PaymentMethodInfoDraft ToDraft()
    {
        return new PaymentMethodInfoDraft()
        {
            InterfaceAccount = this.InterfaceAccount,
            Method = this.Method,
            Name = this.Name,
            PaymentInterface = this.PaymentInterface,
            Token = this.Token,
            Custom = this.Custom?.ToDraft()
        };
    }
}