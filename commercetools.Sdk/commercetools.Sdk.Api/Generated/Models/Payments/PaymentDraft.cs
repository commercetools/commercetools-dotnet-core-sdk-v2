using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentDraft : IPaymentDraft
    {
        public ICustomerResourceIdentifier Customer { get; set; }

        public string AnonymousId { get; set; }

        [ObsoleteAttribute("This property is obsolete", false)]
        public string ExternalId { get; set; }

        public string InterfaceId { get; set; }

        public IMoney AmountPlanned { get; set; }

        public IMoney AmountAuthorized { get; set; }

        public string AuthorizedUntil { get; set; }

        public IMoney AmountPaid { get; set; }

        public IMoney AmountRefunded { get; set; }

        public IPaymentMethodInfo PaymentMethodInfo { get; set; }

        public IPaymentStatusDraft PaymentStatus { get; set; }

        public List<ITransactionDraft> Transactions { get; set; }

        public List<ICustomFieldsDraft> InterfaceInteractions { get; set; }

        public ICustomFieldsDraft Custom { get; set; }

        public string Key { get; set; }
    }
}
