using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Messages
{

    public partial class ReturnInfoSetMessagePayload : IReturnInfoSetMessagePayload
    {
        public string Type { get; set; }

        public IList<IReturnInfo> ReturnInfo { get; set; }
        public IEnumerable<IReturnInfo> ReturnInfoEnumerable { set => ReturnInfo = value.ToList(); }

        public ReturnInfoSetMessagePayload()
        {
            this.Type = "ReturnInfoSet";
        }
    }
}
