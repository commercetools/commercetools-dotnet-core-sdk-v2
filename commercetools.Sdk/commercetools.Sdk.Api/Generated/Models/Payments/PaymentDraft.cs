using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


namespace commercetools.Sdk.Api.Models.Payments
{

    public partial class PaymentDraft : IPaymentDraft
    {
        public ICustomerResourceIdentifier Customer { get; set; }

        public string AnonymousId { get; set; }

        public string InterfaceId { get; set; }

        public IMoney AmountPlanned { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public IPaymentStatusDraft PaymentStatus { get; set; }

        public IList<ITransactionDraft> Transactions { get; set; }
        public IEnumerable<ITransactionDraft> TransactionsEnumerable { set => Transactions = value.ToList(); }


        public IList<ICustomFieldsDraft> InterfaceInteractions { get; set; }
        public IEnumerable<ICustomFieldsDraft> InterfaceInteractionsEnumerable { set => InterfaceInteractions = value.ToList(); }


        public ICustomFieldsDraft Custom { get; set; }

        public string Key { get; set; }
    }
}
