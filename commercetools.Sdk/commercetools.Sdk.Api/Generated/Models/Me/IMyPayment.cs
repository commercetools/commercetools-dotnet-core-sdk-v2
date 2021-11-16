using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Payments;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Me
{
    [DeserializeAs(typeof(commercetools.Api.Models.Me.MyPayment))]
    public partial interface IMyPayment 
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
