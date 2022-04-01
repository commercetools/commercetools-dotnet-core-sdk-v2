using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Me
{
    public partial class MyPayment : IMyPayment
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public ICustomerReference Customer { get; set; }

        public string AnonymousId { get; set; }

        public ITypedMoney AmountPlanned { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public List<ITransaction> Transactions { get; set; }

        public ICustomFields Custom { get; set; }
    }
}
