using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.Customers;
using commercetools.Api.Generated.Models.Payments;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Payments
{
    public interface IPayment : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        ICustomerReference Customer { get; set;}
        
        string AnonymousId { get; set;}
        
        string ExternalId { get; set;}
        
        string InterfaceId { get; set;}
        
        ITypedMoney AmountPlanned { get; set;}
        
        ITypedMoney AmountAuthorized { get; set;}
        
        string AuthorizedUntil { get; set;}
        
        ITypedMoney AmountPaid { get; set;}
        
        ITypedMoney AmountRefunded { get; set;}
        
        IPaymentMethodInfo PaymentMethodInfo { get; set;}
        
        IPaymentStatus PaymentStatus { get; set;}
        
        List<ITransaction> Transactions { get; set;}
        
        List<ICustomFields> InterfaceInteractions { get; set;}
        
        ICustomFields Custom { get; set;}
        
        string Key { get; set;}
    }
}
