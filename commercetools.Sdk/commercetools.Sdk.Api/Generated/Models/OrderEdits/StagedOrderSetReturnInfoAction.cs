using commercetools.Api.Models.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using commercetools.Base.CustomAttributes;


namespace commercetools.Api.Models.OrderEdits
{
    public partial class StagedOrderSetReturnInfoAction : IStagedOrderSetReturnInfoAction
    {
        public string Action { get; set; }

        public List<IReturnInfoDraft> Items { get; set; }
        public StagedOrderSetReturnInfoAction()
        {
            this.Action = "setReturnInfo";
        }
    }
}
