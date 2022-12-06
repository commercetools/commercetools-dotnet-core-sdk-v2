using System.Collections.Generic;
using System.Linq;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnInfoAction : IOrderSetReturnInfoAction
    {
        public string Action { get; set; }

        public IList<IReturnInfoDraft> Items { get; set; }
        public IEnumerable<IReturnInfoDraft> ItemsEnumerable { set => Items = value.ToList(); }

        public OrderSetReturnInfoAction()
        {
            this.Action = "setReturnInfo";
        }
    }
}
