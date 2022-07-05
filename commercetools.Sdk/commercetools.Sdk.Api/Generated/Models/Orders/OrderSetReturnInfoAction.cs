using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderSetReturnInfoAction : IOrderSetReturnInfoAction
    {
        public string Action { get; set; }

        public List<IReturnInfoDraft> Items { get; set; }
        public OrderSetReturnInfoAction()
        {
            this.Action = "setReturnInfo";
        }
    }
}
