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

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentDraft))]
    public partial interface IPaymentDraft
    {
        ICustomerResourceIdentifier Customer { get; set; }

        string AnonymousId { get; set; }

        string InterfaceId { get; set; }

        IMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        IPaymentStatusDraft PaymentStatus { get; set; }

        IList<ITransactionDraft> Transactions { get; set; }
        IEnumerable<ITransactionDraft> TransactionsEnumerable { set => Transactions = value.ToList(); }


        IList<ICustomFieldsDraft> InterfaceInteractions { get; set; }
        IEnumerable<ICustomFieldsDraft> InterfaceInteractionsEnumerable { set => InterfaceInteractions = value.ToList(); }


        ICustomFieldsDraft Custom { get; set; }

        string Key { get; set; }

    }
}
