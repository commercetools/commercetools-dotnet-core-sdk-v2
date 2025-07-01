using commercetools.Sdk.Api.Models.BusinessUnits;
using commercetools.Sdk.Api.Models.Common;
using commercetools.Sdk.Api.Models.Customers;
using commercetools.Sdk.Api.Models.Types;
using System;

namespace commercetools.Sdk.Api.Models.PaymentMethods
{

    public partial class PaymentMethod : IPaymentMethod
    {
        public string Id { get; set; }

        public long Version { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime LastModifiedAt { get; set; }

        public string Key { get; set; }

        public ILocalizedString Name { get; set; }

        public ICustomerReference Customer { get; set; }

        public IBusinessUnitKeyReference BusinessUnit { get; set; }

        public string Method { get; set; }

        public string PaymentInterface { get; set; }

        public string InterfaceAccount { get; set; }

        public IPaymentMethodToken Token { get; set; }

        public IPaymentMethodStatus PaymentMethodStatus { get; set; }

        public bool Default { get; set; }

        public ICustomFields Custom { get; set; }

        public ILastModifiedBy LastModifiedBy { get; set; }

        public ICreatedBy CreatedBy { get; set; }
    }
}
