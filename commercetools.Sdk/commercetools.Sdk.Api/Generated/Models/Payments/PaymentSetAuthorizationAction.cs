using commercetools.Sdk.Api.Models.Common;
using System;


namespace commercetools.Sdk.Api.Models.Payments
{
    public partial class PaymentSetAuthorizationAction : IPaymentSetAuthorizationAction
    {
        public string Action { get; set; }

        public IMoney Amount { get; set; }

        public DateTime? Until { get; set; }
        public PaymentSetAuthorizationAction()
        {
            this.Action = "setAuthorization";
        }
    }
}
