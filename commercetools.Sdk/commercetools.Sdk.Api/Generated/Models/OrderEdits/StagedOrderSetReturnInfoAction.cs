using commercetools.Sdk.Api.Models.Orders;
using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.OrderEdits
{

    public partial class StagedOrderSetReturnInfoAction : IStagedOrderSetReturnInfoAction
    {
        public string Action { get; set; }

        public IList<IReturnInfoDraft> Items { get; set; }
        public IEnumerable<IReturnInfoDraft> ItemsEnumerable { set => Items = value.ToList(); }

        public StagedOrderSetReturnInfoAction()
        {
            this.Action = "setReturnInfo";
        }
    }
}
