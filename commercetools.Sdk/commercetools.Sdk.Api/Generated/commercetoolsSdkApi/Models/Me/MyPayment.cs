using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Sdk.Api.Models.Me
{

    public partial class MyPayment : IMyPayment
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public ICustomerReference Customer { get; set; }

        public string AnonymousId { get; set; }

        public ICentPrecisionMoney AmountPlanned { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public IList<ITransaction> Transactions { get; set; }

        public IEnumerable<ITransaction> TransactionsEnumerable { set => Transactions = value.ToList(); }

        public ICustomFields Custom { get; set; }
    }
}
