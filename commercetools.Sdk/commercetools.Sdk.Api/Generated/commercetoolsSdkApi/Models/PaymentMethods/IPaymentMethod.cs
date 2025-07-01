using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System;
using commercetools.Base.CustomAttributes;
// ReSharper disable CheckNamespace
namespace commercetools.Sdk.Api.Models.PaymentMethods
{
    [DeserializeAs(typeof(commercetools.Sdk.Api.Models.PaymentMethods.PaymentMethod))]
    public partial interface IPaymentMethod : IBaseResource
    {
        new string Id { get; set; }

        new long Version { get; set; }

        string Key { get; set; }

        ILocalizedString Name { get; set; }

        ICustomerReference Customer { get; set; }

        IBusinessUnitKeyReference BusinessUnit { get; set; }

        string Method { get; set; }

        string PaymentInterface { get; set; }

        string InterfaceAccount { get; set; }

        IPaymentMethodToken Token { get; set; }

        IPaymentMethodStatus PaymentMethodStatus { get; set; }

        bool Default { get; set; }

        ICustomFields Custom { get; set; }

        new DateTime CreatedAt { get; set; }

        new DateTime LastModifiedAt { get; set; }

        ILastModifiedBy LastModifiedBy { get; set; }

        ICreatedBy CreatedBy { get; set; }

    }
}
