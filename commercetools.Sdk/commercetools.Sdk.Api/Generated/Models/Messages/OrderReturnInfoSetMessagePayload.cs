using commercetools.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Api.Models.Messages
{
    public partial class OrderReturnInfoSetMessagePayload : IOrderReturnInfoSetMessagePayload
    {
        public string Type { get; set;}
        
        public List<IReturnInfo> ReturnInfo { get; set;}
        public OrderReturnInfoSetMessagePayload()
        { 
           this.Type = "ReturnInfoSet";
        }
    }
}
