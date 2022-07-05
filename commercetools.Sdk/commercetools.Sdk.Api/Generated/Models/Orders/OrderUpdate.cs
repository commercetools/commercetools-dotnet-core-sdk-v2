using System.Collections.Generic;


namespace commercetools.Sdk.Api.Models.Orders
{

    public partial class OrderUpdate : IOrderUpdate
    {
        public long Version { get; set; }

        public List<IOrderUpdateAction> Actions { get; set; }
    }
}
