using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class Payment : IPayment
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }

        public ICustomerReference Customer { get; set; }

        public string AnonymousId { get; set; }

        public string InterfaceId { get; set; }

        public ICentPrecisionMoney AmountPlanned { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public IPaymentStatus PaymentStatus { get; set; }

        public IList<ITransaction> Transactions { get; set; }
        public IEnumerable<ITransaction> TransactionsEnumerable { set => Transactions = value.ToList(); }


        public IList<ICustomFields> InterfaceInteractions { get; set; }
        public IEnumerable<ICustomFields> InterfaceInteractionsEnumerable { set => InterfaceInteractions = value.ToList(); }


        public ICustomFields Custom { get; set; }

        public string Key { get; set; }
    }
}
