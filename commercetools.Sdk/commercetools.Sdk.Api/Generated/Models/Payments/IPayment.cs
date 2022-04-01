using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


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

        string ExternalId { get; set; }

        string InterfaceId { get; set; }

        ITypedMoney AmountPlanned { get; set; }

        ITypedMoney AmountAuthorized { get; set; }

        string AuthorizedUntil { get; set; }

        ITypedMoney AmountPaid { get; set; }

        ITypedMoney AmountRefunded { get; set; }

        IPaymentMethodInfo PaymentMethodInfo { get; set; }

        IPaymentStatus PaymentStatus { get; set; }

        List<ITransaction> Transactions { get; set; }

        List<ICustomFields> InterfaceInteractions { get; set; }

        ICustomFields Custom { get; set; }

        string Key { get; set; }
    }
}
