using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReturnInfoSetMessagePayload : IReturnInfoSetMessagePayload
    {
        public string Type { get; set; }

        public List<IReturnInfo> ReturnInfo { get; set; }
        public ReturnInfoSetMessagePayload()
        {
            this.Type = "ReturnInfoSet";
        }
    }
}
