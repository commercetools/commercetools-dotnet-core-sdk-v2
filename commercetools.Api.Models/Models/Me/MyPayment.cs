using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;

namespace commercetools.Api.Models.Me
{
    public class MyPayment 
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public CustomerReference Customer { get; set;}
        
        public string AnonymousId { get; set;}
        
        public TypedMoney AmountPlanned { get; set;}
        
        public PaymentMethodInfo PaymentMethodInfo { get; set;}
        
        public List<Transaction> Transactions { get; set;}
        
        public CustomFields Custom { get; set;}
    }
}
