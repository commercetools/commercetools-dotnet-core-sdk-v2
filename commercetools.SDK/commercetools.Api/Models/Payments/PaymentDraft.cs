using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;


namespace commercetools.Api.Models.Payments
{
    public partial class PaymentDraft 
    {
        public CustomerResourceIdentifier Customer { get; set;}
        
        public string AnonymousId { get; set;}
        
        public string ExternalId { get; set;}
        
        public string InterfaceId { get; set;}
        
        public Money AmountPlanned { get; set;}
        
        public Money AmountAuthorized { get; set;}
        
        public string AuthorizedUntil { get; set;}
        
        public Money AmountPaid { get; set;}
        
        public Money AmountRefunded { get; set;}
        
        public PaymentMethodInfo PaymentMethodInfo { get; set;}
        
        public PaymentStatusDraft PaymentStatus { get; set;}
        
        public List<TransactionDraft> Transactions { get; set;}
        
        public List<CustomFieldsDraft> InterfaceInteractions { get; set;}
        
        public CustomFieldsDraft Custom { get; set;}
        
        public string Key { get; set;}
    }
}
