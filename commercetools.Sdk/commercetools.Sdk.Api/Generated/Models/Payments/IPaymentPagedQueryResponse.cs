using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentPagedQueryResponse))]
    public partial interface IPaymentPagedQueryResponse 
    {
        long Limit { get; set;}
        
        long Count { get; set;}
        
        long? Total { get; set;}
        
        long Offset { get; set;}
        
        List<IPayment> Results { get; set;}
    }
}
