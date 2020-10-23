using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Customers;
using commercetools.Api.Generated.Models.Payments;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Me
{
    public interface IMyPayment 
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        string AnonymousId { get; set;}
        
        ITypedMoney AmountPlanned { get; set;}
        
        IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        List<ITransaction> Transactions { get; set;}
        
        ICustomFields Custom { get; set;}
    }
}
