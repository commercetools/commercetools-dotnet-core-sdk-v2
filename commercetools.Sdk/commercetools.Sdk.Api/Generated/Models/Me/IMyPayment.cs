using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Payments;
using commercetools.Sdk.Api.Models.Types;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Sdk.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.Me.MyPayment))]
    public partial interface IMyPayment
    {
        string Id { get; set; }

        long Version { get; set; }

        ICustomerReference Customer { get; set; }

        string AnonymousId { get; set; }

        ITypedMoney AmountPlanned { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        List<ITransaction> Transactions { get; set; }

        ICustomFields Custom { get; set; }

    }
}
