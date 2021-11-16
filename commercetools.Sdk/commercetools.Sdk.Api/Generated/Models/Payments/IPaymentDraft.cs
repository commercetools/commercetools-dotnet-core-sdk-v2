using commercetools.Api.Models.Common;
using commercetools.Api.Models.Customers;
using commercetools.Api.Models.Types;
using System;
using System.Collections.Generic;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Payments
{
    [DeserializeAs(typeof(commercetools.Api.Models.Payments.PaymentDraft))]
    public partial interface IPaymentDraft 
    {
        ICustomerResourceIdentifier Customer { get; set;}
        
        string AnonymousId { get; set;}
        
        [ObsoleteAttribute("This property is obsolete", false)]
        string ExternalId { get; set;}
        
        string InterfaceId { get; set;}
        
        IMoney AmountPlanned { get; set;}
        
        IMoney AmountAuthorized { get; set;}
        
        string AuthorizedUntil { get; set;}
        
        IMoney AmountPaid { get; set;}
        
        IMoney AmountRefunded { get; set;}
        
        IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        IPaymentStatusDraft PaymentStatus { get; set;}
        
        List<ITransactionDraft> Transactions { get; set;}
        
        List<ICustomFieldsDraft> InterfaceInteractions { get; set;}
        
        ICustomFieldsDraft Custom { get; set;}
        
        string Key { get; set;}
    }
}
