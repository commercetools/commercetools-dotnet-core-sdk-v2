using commercetools.Api.Models.Carts;
using commercetools.Api.Models.DiscountCodes;
using commercetools.Api.Models.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Api.Models.CustomAttributes;


namespace commercetools.Api.Models.Messages
{
    [DiscriminatorValue("OrderDiscountCodeStateSet")]
    public partial class OrderDiscountCodeStateSetMessagePayload : MessagePayload
    {
        public DiscountCodeReference DiscountCode { get; set;}
        
        public string State { get; set;}
        
        [JsonIgnore]
        public DiscountCodeState StateAsEnum => this.State.GetEnum<DiscountCodeState>();
        
        public string OldState { get; set;}
        
        [JsonIgnore]
        public DiscountCodeState OldStateAsEnum => this.OldState.GetEnum<DiscountCodeState>();
        public OrderDiscountCodeStateSetMessagePayload()
        { 
           this.Type = "OrderDiscountCodeStateSet";
        }
    }
}
