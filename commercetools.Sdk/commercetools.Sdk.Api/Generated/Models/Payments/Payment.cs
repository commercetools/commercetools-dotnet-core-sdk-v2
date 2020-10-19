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
    public partial class Payment : BaseResource
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public LastModifiedBy LastModifiedBy { get; set;}
        
        public CreatedBy CreatedBy { get; set;}
        
        public CustomerReference Customer { get; set;}
        
        public string AnonymousId { get; set;}
        
        public string ExternalId { get; set;}
        
        public string InterfaceId { get; set;}
        
        public TypedMoney AmountPlanned { get; set;}
        
        public TypedMoney AmountAuthorized { get; set;}
        
        public string AuthorizedUntil { get; set;}
        
        public TypedMoney AmountPaid { get; set;}
        
        public TypedMoney AmountRefunded { get; set;}
        
        public PaymentMethodInfo PaymentMethodInfo { get; set;}
        
        public PaymentStatus PaymentStatus { get; set;}
        
        public List<Transaction> Transactions { get; set;}
        
        public List<CustomFields> InterfaceInteractions { get; set;}
        
        public CustomFields Custom { get; set;}
        
        public string Key { get; set;}
    }
}
