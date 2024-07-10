using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using System.Linq;
using commercetools.Base.CustomAttributes;

// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPayment))]
    public partial interface IMyPayment
    {
        string Id { get; set; }

        long Version { get; set; }

        ICustomerReference Customer { get; set; }

        string AnonymousId { get; set; }

        ICentPrecisionMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        IList<ITransaction> Transactions { get; set; }
        IEnumerable<ITransaction> TransactionsEnumerable { set => Transactions = value.ToList(); }


        ICustomFields Custom { get; set; }

    }
}
