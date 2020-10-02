using commercetools.Api.Models.Channels;
using commercetools.Api.Models.CustomerGroups;
using commercetools.Api.Models.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Errors
{
    [DiscriminatorValue("MatchingPriceNotFound")]
    public partial class MatchingPriceNotFoundError : ErrorObject
    {
        public string ProductId { get; set;}
        
        public int VariantId { get; set;}
        
        public string Currency { get; set;}
        
        public string Country { get; set;}
        
        public CustomerGroupReference CustomerGroup { get; set;}
        
        public ChannelReference Channel { get; set;}
        public MatchingPriceNotFoundError()
        { 
           this.Code = "MatchingPriceNotFound";
        }
    }
}
