using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.OrderEdits
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
