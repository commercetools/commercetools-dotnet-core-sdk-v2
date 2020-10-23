using commercetools.Api.Models.Carts;
using commercetools.Api.Models.Common;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    public  partial class OrderDiscountCodeStateSetMessage : IOrderDiscountCodeStateSetMessage
    {
        public string Id { get; set;}
        
        public long Version { get; set;}
        
        public DateTime CreatedAt { get; set;}
        
        public DateTime LastModifiedAt { get; set;}
        
        public ILastModifiedBy LastModifiedBy { get; set;}
        
        public ICreatedBy CreatedBy { get; set;}
        
        public long SequenceNumber { get; set;}
        
        public IReference Resource { get; set;}
        
        public long ResourceVersion { get; set;}
        
        public string Type { get; set;}
        
        public IUserProvidedIdentifiers ResourceUserProvidedIdentifiers { get; set;}
        
        public IDiscountCodeReference DiscountCode { get; set;}
        
        public string State { get; set;}
        
        [JsonIgnore]
        public DiscountCodeState StateAsEnum => this.State.GetEnum<DiscountCodeState>();
        
        public string OldState { get; set;}
        
        [JsonIgnore]
        public DiscountCodeState OldStateAsEnum => this.OldState.GetEnum<DiscountCodeState>();
        public OrderDiscountCodeStateSetMessage()
        { 
           this.Type = "OrderDiscountCodeStateSet";
        }
    }
}
