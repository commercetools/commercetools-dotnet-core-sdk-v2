using commercetools.Api.Models.Channels;
using commercetools.Api.Models.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.Stores
{
    public  partial class StoresAddSupplyChannelsAction : IStoresAddSupplyChannelsAction
    {
        public string Action { get; set;}
        
        public IChannelResourceIdentifier SupplyChannel { get; set;}
        public StoresAddSupplyChannelsAction()
        { 
           this.Action = "addSupplyChannel";
        }
    }
}
