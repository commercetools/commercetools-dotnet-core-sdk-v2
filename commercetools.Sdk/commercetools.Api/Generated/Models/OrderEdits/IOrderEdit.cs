using commercetools.Api.Generated.Models.Common;
using commercetools.Api.Generated.Models.OrderEdits;
using commercetools.Api.Generated.Models.Orders;
using commercetools.Api.Generated.Models.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.OrderEdits
{
    public interface IOrderEdit : IBaseResource
    {
        string Id { get; set;}
        
        long Version { get; set;}
        
        DateTime CreatedAt { get; set;}
        
        DateTime LastModifiedAt { get; set;}
        
        ILastModifiedBy LastModifiedBy { get; set;}
        
        ICreatedBy CreatedBy { get; set;}
        
        string Key { get; set;}
        
        IOrderReference Resource { get; set;}
        
        List<IStagedOrderUpdateAction> StagedActions { get; set;}
        
        ICustomFields Custom { get; set;}
        
        IOrderEditResult Result { get; set;}
        
        string Comment { get; set;}
    }
}
