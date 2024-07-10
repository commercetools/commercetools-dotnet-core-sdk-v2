using commercetools.Sdk.Api.Models.Messages;
using commercetools.Sdk.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;
using commercetools.Base.Models;


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
