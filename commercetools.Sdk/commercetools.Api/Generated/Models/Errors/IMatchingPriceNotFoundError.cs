using commercetools.Api.Generated.Models.Channels;
using commercetools.Api.Generated.Models.CustomerGroups;
using commercetools.Api.Generated.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Generated.Models.Errors
{
    public interface IMatchingPriceNotFoundError : IErrorObject
    {
        string ProductId { get; set;}
        
        int VariantId { get; set;}
        
        string Currency { get; set;}
        
        string Country { get; set;}
        
        ICustomerGroupReference CustomerGroup { get; set;}
        
        IChannelReference Channel { get; set;}
    }
}
