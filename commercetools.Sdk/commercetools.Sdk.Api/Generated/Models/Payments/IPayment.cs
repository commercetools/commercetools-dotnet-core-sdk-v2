using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Payments.Payment))]
    public partial interface IPayment : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

        ICustomerReference Customer { get; set; }

        string AnonymousId { get; set; }

        string InterfaceId { get; set; }

        ICentPrecisionMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        IPaymentStatus PaymentStatus { get; set; }

        IList<ITransaction> Transactions { get; set; }
        IEnumerable<ITransaction> TransactionsEnumerable { set => Transactions = value.ToList(); }


        IList<ICustomFields> InterfaceInteractions { get; set; }
        IEnumerable<ICustomFields> InterfaceInteractionsEnumerable { set => InterfaceInteractions = value.ToList(); }


        ICustomFields Custom { get; set; }

        string Key { get; set; }

    }
}
