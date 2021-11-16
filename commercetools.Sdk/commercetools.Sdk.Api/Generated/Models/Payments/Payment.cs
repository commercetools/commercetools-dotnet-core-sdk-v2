using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    public partial class Payment : IPayment
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public ICustomerReference Customer { get; set;}
        
        public string AnonymousId { get; set;}
        
        public string ExternalId { get; set;}
        
        public string InterfaceId { get; set;}
        
        public ITypedMoney AmountPlanned { get; set;}
        
        public ITypedMoney AmountAuthorized { get; set;}
        
        public string AuthorizedUntil { get; set;}
        
        public ITypedMoney AmountPaid { get; set;}
        
        public ITypedMoney AmountRefunded { get; set;}
        
        public IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        public IPaymentStatus PaymentStatus { get; set;}
        
        public List<ITransaction> Transactions { get; set;}
        
        public List<ICustomFields> InterfaceInteractions { get; set;}
        
        public ICustomFields Custom { get; set;}
        
        public string Key { get; set;}
    }
}
