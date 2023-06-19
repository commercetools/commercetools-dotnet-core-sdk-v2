using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.PaymentDraft))]
    public partial interface IPaymentDraft
    {
        ICustomerResourceIdentifier Customer { get; set; }

        string AnonymousId { get; set; }

        string ExternalId { get; set; }

        string InterfaceId { get; set; }

        IMoney AmountPlanned { get; set; }

        IMoney AmountAuthorized { get; set; }

        string AuthorizedUntil { get; set; }

        IMoney AmountPaid { get; set; }

        IMoney AmountRefunded { get; set; }

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
